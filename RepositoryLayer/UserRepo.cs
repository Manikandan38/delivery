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

        public bool AddNewUser(UserDetail U)
        {
            try
            {
                U.IsVerified = true;

                _context.UserDetail.Add(U);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }


        public bool DeleteUser(int id)
        {
            try
            {
                UserDetail U = _context.UserDetail.Find(id);
                _context.UserDetail.Remove(U);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public UserDetail GetUserByID(int id)
        {
            return (_context.UserDetail.Find(id));
        }

        public List<UserDetail> GetAllUser()
        {
            return _context.UserDetail.ToList();
        }


        public bool UpdateUser(int id, UserDetail U)
        {
            try
            {
                U.UserID = id;
                _context.Update(U);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool UserExists(int id)
        {
            return _context.UserDetail.Any(u => u.UserID == id);
        }

    }
}
