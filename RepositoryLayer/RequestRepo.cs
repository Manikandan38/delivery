using DeliveryBookingAPI.DataLayer;
using DeliveryBookingAPI.ModelLayer;
using DeliveryBookingAPI.RepositoryLayer.RepoInterfaceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingAPI.RepositoryLayer
{
    public class RequestRepo : IRequest
    {
        private readonly DeliveryBookingAPIContext _context;

        public RequestRepo()
        {

        }

        public RequestRepo(DeliveryBookingAPIContext context)
        {
            _context = context;
        }

        public UserRequest AddNewRequest(UserRequest R)
        {
            _context.UserRequest.Add(R);
            _context.SaveChanges();
            return R;
        }


        public void DeleteRequest(int id)
        {
            UserRequest R = _context.UserRequest.Find(id);
            _context.UserRequest.Remove(R);
            _context.SaveChanges();
        }

        public UserRequest GetRequestByID(int id)
        {
            return (_context.UserRequest.Find(id));
        }

        public List<UserRequest> GetAllRequest()
        {   
            return _context.UserRequest.ToList();
        }


        public UserRequest UpdateRequest(int id, UserRequest R)
        {
            R.RequestID = id;
            _context.Update(R);
            _context.SaveChanges();
            return R;
        }

        public bool RequestExists(int id)
        {
            return _context.UserRequest.Any(c => c.RequestID == id);
        }
    }
}
