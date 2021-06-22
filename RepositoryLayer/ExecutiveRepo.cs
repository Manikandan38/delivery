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

        public ExecutiveDetail AddNewExecutive(ExecutiveDetail E)
        {
            E.IsVerified = true;

            _context.ExecutiveDetail.Add(E);
            _context.SaveChanges();
            return E;
        }


        public void DeleteExecutive(int id)
        {
            ExecutiveDetail E = _context.ExecutiveDetail.Find(id);
            _context.ExecutiveDetail.Remove(E);
            _context.SaveChanges();
        }

        public ExecutiveDetail GetExecutiveByID(int id)
        {
            return (_context.ExecutiveDetail.Find(id));
        }

        public List<ExecutiveDetail> GetAllExecutive()
        {
            return _context.ExecutiveDetail.ToList();
        }


        public ExecutiveDetail UpdateExecutive(int id, ExecutiveDetail E)
        {
            E.ExecutiveID = id;
            _context.Update(E);
            _context.SaveChanges();
            return E;
        }

        public bool ExecutiveExists(int id)
        {
            return _context.ExecutiveDetail.Any(e => e.ExecutiveID == id);
        }
    }
}
