using DeliveryBookingAPI.ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingAPI.ProviderLayer.ProvInterfaceLayer
{
    public interface IProviderExecutive
    {
        public ExecutiveDetail AddNewExecutive(ExecutiveDetail C);
        public void DeleteExecutive(int id);
        public ExecutiveDetail GetExecutiveByID(int id);
        public List<ExecutiveDetail> GetAllExecutive();
        public ExecutiveDetail UpdateExecutive(int id, ExecutiveDetail C);
        public bool ExecutiveExists(int id);
    }
}
