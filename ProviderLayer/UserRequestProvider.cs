using DeliveryBookingAPI.ModelLayer;
using DeliveryBookingAPI.ProviderLayer.ProvInterfaceLayer;
using DeliveryBookingAPI.RepositoryLayer.RepoInterfaceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingAPI.ProviderLayer
{
    public class UserRequestProvider : IProviderRequest
    {
        private readonly IRequest _repo;

        public UserRequestProvider()
        {

        }

        public UserRequestProvider(IRequest repo)
        {
            _repo = repo;
        }

        public UserRequest AddNewRequest(UserRequest C)
        {
            _repo.AddNewRequest(C);
            return C;
        }

        public void DeleteRequest(int id)
        {
            _repo.DeleteRequest(id);
        }

        public List<UserRequest> GetAllRequest()
        {
            return _repo.GetAllRequest();
        }

        public UserRequest GetRequestByID(int id)
        {
            return _repo.GetRequestByID(id);
        }

        public bool RequestExists(int id)
        {
            return _repo.RequestExists(id);
        }

        public UserRequest UpdateRequest(int id, UserRequest C)
        {
            return _repo.UpdateRequest(id, C);
        }
    }
}
