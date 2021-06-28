﻿using DeliveryBookingAPI.ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingAPI.RepositoryLayer.RepoInterfaceLayer
{
    public interface IExecutive
    {
        public bool AddNewExecutive(ExecutiveDetail C);
        public bool DeleteExecutive(int id);
        public ExecutiveDetail GetExecutiveByID(int id);
        public List<ExecutiveDetail> GetAllExecutive();
        public bool UpdateExecutive(int id, ExecutiveDetail C);
        public bool ExecutiveExists(int id);
    }
}
