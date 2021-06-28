using DeliveryBookingAPI.ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingAPI.RepositoryLayer.RepoInterfaceLayer
{
    public interface IEResponse
    {
        public bool AddNewResponse(EResponse C);
        public bool DeleteResponse(int id);
        public EResponse GetResponseByID(int id);
        public List<EResponse> GetAllResponse();
        public bool UpdateResponse(int id, EResponse C);
        public bool ResponseExists(int id);
    }
}
