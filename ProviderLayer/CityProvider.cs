using DeliveryBookingAPI.ModelLayer;
using DeliveryBookingAPI.ProviderLayer.ProvInterfaceLayer;
using DeliveryBookingAPI.RepositoryLayer.RepoInterfaceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingAPI.ProviderLayer
{
    public class CityProvider : IProviderCity
    {
        private readonly ICity _repo;

        public CityProvider()
        {

        }

        public CityProvider(ICity repo)
        {
            _repo = repo;
        }

        public City AddNewCity(City C)
        {
            _repo.AddNewCity(C);
            return C;
        }

        public bool CityExists(int id)
        {
            return _repo.CityExists(id);
        }

        public void DeleteCity(int id)
        {
            _repo.DeleteCity(id);
        }

        public List<City> GetAllCity()
        {
            return _repo.GetAllCity();
        }

        public City GetCityByID(int id)
        {
            return _repo.GetCityByID(id);
        }

        public City UpdateCity(int id, City C)
        {
            _repo.UpdateCity(id, C);
            return C;
        }
    }
}
