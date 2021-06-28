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

        public bool AddNewRequest(UserRequest C)
        {
            try
            {
                _repo.AddNewRequest(C);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool DeleteRequest(int id)
        {
            try
            {

                _repo.DeleteRequest(id);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
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

        public bool UpdateRequest(int id, UserRequest C)
        {
            try
            {
                _repo.UpdateRequest(id, C);
                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
