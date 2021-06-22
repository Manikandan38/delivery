using DeliveryBookingAPI.ModelLayer;
using DeliveryBookingAPI.ProviderLayer.ProvInterfaceLayer;
using DeliveryBookingAPI.RepositoryLayer.RepoInterfaceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingAPI.ProviderLayer
{
    public class ExecutiveProvider : IProviderExecutive
    {
        private readonly IExecutive _repo;

        public ExecutiveProvider()
        {

        }

        public ExecutiveProvider(IExecutive repo)
        {
            _repo = repo;
        }

        public ExecutiveDetail AddNewExecutive(ExecutiveDetail C)
        {
            _repo.AddNewExecutive(C);
            return C;
        }

        public void DeleteExecutive(int id)
        {
            _repo.DeleteExecutive(id);
        }

        public bool ExecutiveExists(int id)
        {
            return _repo.ExecutiveExists(id);
        }

        public List<ExecutiveDetail> GetAllExecutive()
        {
            return _repo.GetAllExecutive();
        }

        public ExecutiveDetail GetExecutiveByID(int id)
        {
            return _repo.GetExecutiveByID(id);
        }

        public ExecutiveDetail UpdateExecutive(int id, ExecutiveDetail C)
        {
            _repo.UpdateExecutive(id, C);
            return C;
        }
    }
}
