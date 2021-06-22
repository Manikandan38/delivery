using DeliveryBookingAPI.ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingAPI.RepositoryLayer.RepoInterfaceLayer
{
    public interface IResponse
    {
        public Response AddNewResponse(Response C);
        public void DeleteResponse(int id);
        public Response GetResponseByID(int id);
        public List<Response> GetAllResponse();
        public Response UpdateResponse(int id, Response C);
        public bool ResponseExists(int id);
    }
}
