using DeliveryBookingAPI.ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingAPI.RepositoryLayer.RepoInterfaceLayer
{
    public interface IRequest
    {
        public bool AddNewRequest(UserRequest C);
        public bool DeleteRequest(int id);
        public UserRequest GetRequestByID(int id);
        public List<UserRequest> GetAllRequest();
        public bool UpdateRequest(int id, UserRequest C);
        public bool RequestExists(int id);
    }
}
