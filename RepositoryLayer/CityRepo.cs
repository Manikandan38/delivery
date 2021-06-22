using DeliveryBookingAPI.DataLayer;
using DeliveryBookingAPI.ModelLayer;
using DeliveryBookingAPI.RepositoryLayer.RepoInterfaceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeliveryBookingAPI.RepositoryLayer
{
    public class CityRepo : ICity
    {
        private readonly DeliveryBookingAPIContext _context;

        public CityRepo()
        {

        }

        public CityRepo(DeliveryBookingAPIContext context)
        {
            _context = context;
        }

        public City AddNewCity(City C)
        {

            _context.City.Add(C);
            _context.SaveChanges();
            return C;
        }


        public void DeleteCity(int id)
        {
            City C = _context.City.Find(id);
            _context.City.Remove(C);
            _context.SaveChanges();
        }

        public City GetCityByID(int id)
        {
            return (_context.City.Find(id));
        }

        public List<City> GetAllCity()
        {
            return _context.City.ToList();
        }


        public City UpdateCity(int id, City C)
        {
            _context.Update(C);
            _context.SaveChanges();
            return C;
        }

        public bool CityExists(int id)
        {
            return _context.City.Any(c => c.CityID == id);
        }
    }
}
