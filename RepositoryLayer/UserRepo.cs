using DeliveryBookingAPI.ModelLayer;
using DeliveryBookingAPI.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DeliveryBookingAPI.RepositoryLayer.RepoInterfaceLayer;

namespace DeliveryBookingAPI.RepositoryLayer
{
    public class UserRepo : IUser
    {
        private readonly DeliveryBookingAPIContext _context;

        public UserRepo()
        {

        }

        public UserRepo(DeliveryBookingAPIContext context)
        {
            _context = context;
        }

        public UserDetail AddNewUser(UserDetail U)
        {
            U.IsVerified = true;

            _context.UserDetail.Add(U);
            _context.SaveChanges();
            return U;
        }


        public void DeleteUser(int id)
        {
            UserDetail U = _context.UserDetail.Find(id);
            _context.UserDetail.Remove(U);
            _context.SaveChanges();
        }

        public UserDetail GetUserByID(int id)
        {
            return (_context.UserDetail.Find(id));
        }

        public List<UserDetail> GetAllUser()
        {
            return _context.UserDetail.ToList();
        }


        public UserDetail UpdateUser(int id, UserDetail U)
        {
            U.UserID = id;
            _context.Update(U);
            _context.SaveChanges();
            return U;
        }

        public bool UserExists(int id)
        {
            return _context.UserDetail.Any(u => u.UserID == id);
        }

    }
}
