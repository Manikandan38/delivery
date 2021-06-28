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

        public bool AddNewExecutive(ExecutiveDetail C)
        {
            try
            {
                _repo.AddNewExecutive(C);
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }

        }

        public bool DeleteExecutive(int id)
        {
            try
            {
                _repo.DeleteExecutive(id);
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
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

        public bool UpdateExecutive(int id, ExecutiveDetail C)
        {
            try
            {
                _repo.UpdateExecutive(id, C);
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
