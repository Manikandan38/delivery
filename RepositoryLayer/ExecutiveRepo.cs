using DeliveryBookingAPI.DataLayer;
using DeliveryBookingAPI.ModelLayer;
using DeliveryBookingAPI.RepositoryLayer.RepoInterfaceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingAPI.RepositoryLayer
{
    public class ExecutiveRepo : IExecutive
    {
        private readonly DeliveryBookingAPIContext _context;

        public ExecutiveRepo()
        {

        }

        public ExecutiveRepo(DeliveryBookingAPIContext context)
        {
            _context = context;
        }

        public bool AddNewExecutive(ExecutiveDetail E)
        {
            try
            {
                E.IsVerified = true;

                _context.ExecutiveDetail.Add(E);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }


        public bool DeleteExecutive(int id)
        {
            try
            {
                ExecutiveDetail E = _context.ExecutiveDetail.Find(id);
                _context.ExecutiveDetail.Remove(E);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public ExecutiveDetail GetExecutiveByID(int id)
        {
            return (_context.ExecutiveDetail.Find(id));
        }

        public List<ExecutiveDetail> GetAllExecutive()
        {
            return _context.ExecutiveDetail.ToList();
        }


        public bool UpdateExecutive(int id, ExecutiveDetail E)
        {
            try
            {
                E.ExecutiveID = id;
                _context.Update(E);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        public bool ExecutiveExists(int id)
        {
            return _context.ExecutiveDetail.Any(e => e.ExecutiveID == id);
        }
    }
}
