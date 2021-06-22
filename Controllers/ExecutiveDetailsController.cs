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
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
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
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public ActionResult<ExecutiveDetail> PostExecutiveDetail(ExecutiveDetail executiveDetail)
        {
            _exec.AddNewExecutive(executiveDetail);

            return CreatedAtAction("GetExecutiveByID", new { id = executiveDetail.ExecutiveID }, executiveDetail);
        }

        // DELETE: api/ExecutiveDetails/5
        [HttpDelete("{id}")]
        public IActionResult DeleteExecutiveDetail(int id)
        {
            _exec.DeleteExecutive(id);

            return NoContent();
        }

    }
}
