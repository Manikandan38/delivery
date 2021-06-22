using DeliveryBookingAPI.DataLayer;
using DeliveryBookingAPI.ModelLayer;
using DeliveryBookingAPI.RepositoryLayer.RepoInterfaceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingAPI.RepositoryLayer
{
    public class ResponseRepo : IResponse
    {

        private readonly DeliveryBookingAPIContext _context;

        public ResponseRepo()
        {

        }

        public ResponseRepo(DeliveryBookingAPIContext context)
        {
            _context = context;
        }

        public Response AddNewResponse(Response R)
        {

            _context.Response.Add(R);
            _context.SaveChanges();
            return R;
        }


        public void DeleteResponse(int id)
        {
            Response R = _context.Response.Find(id);
            _context.Response.Remove(R);
            _context.SaveChanges();
        }

        public Response GetResponseByID(int id)
        {
            return (_context.Response.Find(id));
        }

        public List<Response> GetAllResponse()
        {
            return _context.Response.ToList();
        }


        public Response UpdateResponse(int id, Response R)
        {
            _context.Update(R);
            _context.SaveChanges();
            return R;
        }

        public bool ResponseExists(int id)
        {
            return _context.Response.Any(c => c.ResponseID == id);
        }
    }
}
