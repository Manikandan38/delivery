using DeliveryBookingAPI.ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingAPI.ProviderLayer.ProvInterfaceLayer
{
    public interface IProviderCity
    {
        public bool AddNewCity(City C);
        public bool DeleteCity(int id);
        public City GetCityByID(int id);
        public List<City> GetAllCity();
        public bool UpdateCity(int id, City C);
        public bool CityExists(int id);
    }
}
