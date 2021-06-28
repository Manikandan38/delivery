using DeliveryBookingAPI.DataLayer;
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

        public bool AddNewCity(City C)
        {
            try
            {
                _repo.AddNewCity(C);
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool CityExists(int id)
        {
            return _repo.CityExists(id);
        }

        public bool DeleteCity(int id)
        {
            try
            {
                _repo.DeleteCity(id);
                return true;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<City> GetAllCity()
        {
            return _repo.GetAllCity();
        }

        public City GetCityByID(int id)
        {
            return _repo.GetCityByID(id);
        }

        public bool UpdateCity(int id, City C)
        {
            try
            {
                _repo.UpdateCity(id, C);
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
