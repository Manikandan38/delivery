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
    public class ExecutiveDetailsController : ControllerBase
    {
        private readonly IProviderExecutive _exec;

        public ExecutiveDetailsController(IProviderExecutive context)
        {
            _exec = context;
        }



        // GET: api/ExecutiveDetails
        [HttpGet]
        public List<ExecutiveDetail> GetAllExecutive()
        {
            return _exec.GetAllExecutive();
        }



        // GET: api/ExecutiveDetails/5
        [HttpGet("{id}")]
        public ActionResult<ExecutiveDetail> GetExecutiveByID(int id)
        {
            return _exec.GetExecutiveByID(id);
        }




        // PUT: api/ExecutiveDetails/5
        [HttpPut("{id}")]
        public IActionResult PutExecutiveDetail(int id, ExecutiveDetail executiveDetail)
        {
            try
            {
                _exec.UpdateExecutive(id, executiveDetail);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_exec.ExecutiveExists(id))
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




        // POST: api/ExecutiveDetails
        [HttpPost]
        public ActionResult<ExecutiveDetail> PostExecutiveDetail(ExecutiveDetail executiveDetail)
        {
            try
            {
                _exec.AddNewExecutive(executiveDetail);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return CreatedAtAction("GetExecutiveByID", new { id = executiveDetail.ExecutiveID }, executiveDetail);
        }



        // DELETE: api/ExecutiveDetails/5
        [HttpDelete("{id}")]
        public IActionResult DeleteExecutiveDetail(int id)
        {
            try
            {
                _exec.DeleteExecutive(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return NoContent();
        }

    }
}
