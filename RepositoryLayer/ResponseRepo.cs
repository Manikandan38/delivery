using DeliveryBookingAPI.DataLayer;
using DeliveryBookingAPI.ModelLayer;
using DeliveryBookingAPI.RepositoryLayer.RepoInterfaceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingAPI.RepositoryLayer
{
    public class ResponseRepo : IEResponse
    {

        private readonly DeliveryBookingAPIContext _context;

        public ResponseRepo()
        {

        }

        public ResponseRepo(DeliveryBookingAPIContext context)
        {
            _context = context;
        }

        public bool AddNewResponse(EResponse R)
        {

            try
            {
                _context.EResponse.Add(R);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }


        public bool DeleteResponse(int id)
        {
            try
            {
                EResponse R = _context.EResponse.Find(id);
                _context.EResponse.Remove(R);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false; 
            }
        }

        public EResponse GetResponseByID(int id)
        {
            return (_context.EResponse.Find(id));
        }

        public List<EResponse> GetAllResponse()
        {
            return _context.EResponse.ToList();
        }


        public bool UpdateResponse(int id, EResponse R)
        {
            try
            {
                _context.Update(R);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        public bool ResponseExists(int id)
        {
            return _context.EResponse.Any(c => c.ResponseID == id);
        }
    }
}
