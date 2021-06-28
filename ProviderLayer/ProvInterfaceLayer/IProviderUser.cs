using DeliveryBookingAPI.ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingAPI.ProviderLayer.ProvInterfaceLayer
{
    public interface IProviderUser
    {
        public bool AddNewUser(UserDetail C);
        public bool DeleteUser(int id);
        public UserDetail GetUserByID(int id);
        public List<UserDetail> GetAllUser();
        public bool UpdateUser(int id, UserDetail C);
        public bool UserExists(int id);
    }
}
