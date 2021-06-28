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
    public class UserRequestsController : ControllerBase
    {
        private readonly IProviderRequest _req;

        public UserRequestsController(IProviderRequest context)
        {
            _req = context;
        }



        // GET: api/UserRequests
        [HttpGet]
        public List<UserRequest> GetAllRequest()
        {
            return _req.GetAllRequest();
        }



        // GET: api/UserRequests/5
        [HttpGet("{id}")]
        public ActionResult<UserRequest> GetRequestByID(int id)
        {
            return _req.GetRequestByID(id);
        }


        
        // PUT: api/UserRequests/5
        [HttpPut("{id}")]
        public IActionResult PutUserRequest(int id, UserRequest userRequest)
        {

            try
            {
                _req.UpdateRequest(id, userRequest);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_req.RequestExists(id))
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



        // POST: api/UserRequests
        [HttpPost]
        public ActionResult<UserRequest> PostUserRequest(UserRequest userRequest)
        {
            try
            {
                _req.AddNewRequest(userRequest);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return CreatedAtAction("GetRequestByID", new { id = userRequest.RequestID }, userRequest);
        }



        // DELETE: api/UserRequests/5
        [HttpDelete("{id}")]
        public IActionResult DeleteUserRequest(int id)
        {
            try
            {
                _req.DeleteRequest(id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return NoContent();
        }

    }
}
