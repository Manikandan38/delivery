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
    public class UserDetailsController : ControllerBase
    {
        private readonly IProviderUser _user;

        public UserDetailsController(IProviderUser context)
        {
            _user = context;
        }

        // GET: api/ExecutiveDetails
        [HttpGet]
        public List<UserDetail> GetAllUser()
        {
            return _user.GetAllUser();
        }

        // GET: api/ExecutiveDetails/5
        [HttpGet("{id}")]
        public ActionResult<UserDetail> GetUserByID(int id)
        {
            return _user.GetUserByID(id);
        }

        // PUT: api/ExecutiveDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IActionResult PutUserDetail(int id, UserDetail userdetail)
        {
            try
            {
                _user.UpdateUser(id, userdetail);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (_user.UserExists(id))
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
        public ActionResult<UserDetail> PostUserDetail(UserDetail userdetail)
        {
            _user.AddNewUser(userdetail);

            return CreatedAtAction("GetUserByID", new { id = userdetail.UserID }, userdetail);
        }

        // DELETE: api/ExecutiveDetails/5
        [HttpDelete("{id}")]
        public IActionResult DeleteUserDetail(int id)
        {
            _user.DeleteUser(id);

            return NoContent();
        }
    }
}
