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
    public class EResponsesController : ControllerBase
    {
        private readonly IProviderResponse _resp;

        public EResponsesController(IProviderResponse context)
        {
            _resp = context;
        }



        // GET: api/Cities
        [HttpGet]
        public List<EResponse> GetAllResponse()
        {
            return _resp.GetAllResponse();
        }



        // GET: api/Cities/5
        [HttpGet("{id}")]
        public ActionResult<EResponse> GetResponseByID(int id)
        {
            return _resp.GetResponseByID(id);
        }




        // PUT: api/Cities/5
        [HttpPut("{id}")]
        public IActionResult PutResponse(int id, EResponse response)
        {
            try
            {
                _resp.UpdateResponse(id, response);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_resp.ResponseExists(id))
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
        [HttpPost]
        public ActionResult<EResponse> PostResponse(EResponse response)
        {
            try
            {
                _resp.AddNewResponse(response);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return CreatedAtAction("GetResponseByID", new { id = response.ResponseID }, response);
        }



        // DELETE: api/Cities/5
        [HttpDelete("{id}")]
        public IActionResult DeleteResponse(int id)
        {
            try
            {
                _resp.DeleteResponse(id);
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            return NoContent();
        }
    }
}
