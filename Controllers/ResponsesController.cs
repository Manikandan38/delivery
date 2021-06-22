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
    public class ResponsesController : ControllerBase
    {
        private readonly IProviderResponse _resp;

        public ResponsesController(IProviderResponse context)
        {
            _resp = context;
        }

        // GET: api/Cities
        [HttpGet]
        public List<Response> GetAllResponse()
        {
            return _resp.GetAllResponse();
        }

        // GET: api/Cities/5
        [HttpGet("{id}")]
        public ActionResult<Response> GetResponseByID(int id)
        {
            return _resp.GetResponseByID(id);
        }

        // PUT: api/Cities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutResponse(int id, Response response)
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
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<Response> PostResponse(Response response)
        {
            _resp.AddNewResponse(response);

            return CreatedAtAction("GetResponseByID", new { id = response.ResponseID }, response);
        }

        // DELETE: api/Cities/5
        [HttpDelete("{id}")]
        public IActionResult DeleteResponse(int id)
        {
            _resp.DeleteResponse(id);
            return NoContent();
        }
    }
}
