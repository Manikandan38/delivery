using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DeliveryBookingAPI.DataLayer;
using DeliveryBookingAPI.ModelLayer;
using DeliveryBookingAPI.ProviderLayer.ProvInterfaceLayer;

namespace DeliveryBookingAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CitiesController : ControllerBase
    {
        private readonly IProviderCity _city;

        public CitiesController(IProviderCity context)
        {
            _city = context;
        }

        // GET: api/Cities
        [HttpGet]
        public List<City> GetAllCity()
        {
            return _city.GetAllCity();
        }

        // GET: api/Cities/5
        [HttpGet("{id}")]
        public ActionResult<City> GetCityByID(int id)
        {
            return _city.GetCityByID(id);
        }

        // PUT: api/Cities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutCity(int id, City city)
        {
            try
            {
                _city.UpdateCity(id, city);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_city.CityExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Cities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<City> PostCity(City city)
        {
            _city.AddNewCity(city);

            return CreatedAtAction("GetCityByID", new { id = city.CityID }, city);
        }

        // DELETE: api/Cities/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCity(int id)
        {
            _city.DeleteCity(id);
            return NoContent();
        }
    }
}
