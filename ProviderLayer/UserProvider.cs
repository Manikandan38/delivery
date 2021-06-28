using DeliveryBookingAPI.ModelLayer;
using DeliveryBookingAPI.ProviderLayer.ProvInterfaceLayer;
using DeliveryBookingAPI.RepositoryLayer.RepoInterfaceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingAPI.ProviderLayer
{
    public class UserProvider : IProviderUser
    {
        private readonly IUser _repo;

        public UserProvider()
        {

        }

        public UserProvider(IUser repo)
        {
            _repo = repo;
        }

        public bool AddNewUser(UserDetail C)
        {
            try
            {
                _repo.AddNewUser(C);
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
                _repo.DeleteUser(id);
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<UserDetail> GetAllUser()
        {
            return _repo.GetAllUser();
        }

        public UserDetail GetUserByID(int id)
        {
            return _repo.GetUserByID(id);
        }

        public bool UpdateUser(int id, UserDetail C)
        {
            try
            {
                _repo.UpdateUser(id, C);
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
            return _repo.UserExists(id);
        }
    }
}
