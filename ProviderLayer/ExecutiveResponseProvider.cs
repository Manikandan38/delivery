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
        private readonly IEResponse _repo;

        public ExecutiveResponseProvider()
        {

        }

        public ExecutiveResponseProvider(IEResponse repo)
        {
            _repo = repo;
        }

        public bool AddNewResponse(EResponse C)
        {
            try
            {
                _repo.AddNewResponse(C);
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool DeleteResponse(int id)
        {
            try
            {
                _repo.DeleteResponse(id);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<EResponse> GetAllResponse()
        {
            return _repo.GetAllResponse();
        }

        public EResponse GetResponseByID(int id)
        {
            return _repo.GetResponseByID(id);
        }

        public bool ResponseExists(int id)
        {
            return _repo.ResponseExists(id);
        }

        public bool UpdateResponse(int id, EResponse C)
        {
            try
            {
                _repo.UpdateResponse(id, C);
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
