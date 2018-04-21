using System.Collections.Generic;
using System.Linq;
using OdeToFood.Data;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public class SqlRestaurantData : IRestaurantData
    {
        private OdeToFoodDbContext _context;

        public SqlRestaurantData(OdeToFoodDbContext context)
        {
            _context = context;
        }

        public Restaurant Add(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            //TODO: unit of work
            _context.SaveChanges();
            return restaurant;
        }

        public Restaurant Get(int id)
        {
            return _context.Restaurants.FirstOrDefault(x => x.Id == id);
        }

        //IQueryable
        public IEnumerable<Restaurant> GetAll()
        {
            return _context.Restaurants.OrderBy(x => x.Name);
        }

        public Restaurant Update(Restaurant restaurant)
        {
            _context.Attach(restaurant).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return restaurant;
        }
    }
}
