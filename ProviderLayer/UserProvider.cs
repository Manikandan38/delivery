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

        public UserDetail AddNewUser(UserDetail C)
        {
            _repo.AddNewUser(C);
            return C;
        }

        public void DeleteUser(int id)
        {
            _repo.DeleteUser(id);
        }

        public List<UserDetail> GetAllUser()
        {
            return _repo.GetAllUser();
        }

        public UserDetail GetUserByID(int id)
        {
            return _repo.GetUserByID(id);
        }

        public UserDetail UpdateUser(int id, UserDetail C)
        {
            _repo.UpdateUser(id, C);
            return C;
        }

        public bool UserExists(int id)
        {
            return _repo.UserExists(id);
        }
    }
}
