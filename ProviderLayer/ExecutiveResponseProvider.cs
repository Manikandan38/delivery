using DeliveryBookingAPI.ModelLayer;
using DeliveryBookingAPI.ProviderLayer.ProvInterfaceLayer;
using DeliveryBookingAPI.RepositoryLayer;
using DeliveryBookingAPI.RepositoryLayer.RepoInterfaceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingAPI.ProviderLayer
{
    public class ExecutiveResponseProvider : IProviderResponse
    {
        private readonly IResponse _repo;

        public ExecutiveResponseProvider()
        {

        }

        public ExecutiveResponseProvider(IResponse repo)
        {
            _repo = repo;
        }

        public Response AddNewResponse(Response C)
        {
            _repo.AddNewResponse(C);
            return C;
        }

        public void DeleteResponse(int id)
        {
            _repo.DeleteResponse(id);
        }

        public List<Response> GetAllResponse()
        {
            return _repo.GetAllResponse();
        }

        public Response GetResponseByID(int id)
        {
            return _repo.GetResponseByID(id);
        }

        public bool ResponseExists(int id)
        {
            return _repo.ResponseExists(id);
        }

        public Response UpdateResponse(int id, Response C)
        {
            _repo.UpdateResponse(id, C);
            return C;
        }
    }
}
