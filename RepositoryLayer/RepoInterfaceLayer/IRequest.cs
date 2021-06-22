using DeliveryBookingAPI.ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingAPI.RepositoryLayer.RepoInterfaceLayer
{
    public interface IRequest
    {
        public UserRequest AddNewRequest(UserRequest C);
        public void DeleteRequest(int id);
        public UserRequest GetRequestByID(int id);
        public List<UserRequest> GetAllRequest();
        public UserRequest UpdateRequest(int id, UserRequest C);
        public bool RequestExists(int id);
    }
}
