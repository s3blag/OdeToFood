using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OdeToFood.Models;

namespace OdeToFood.Services
{
    public class InMemoryRestaurant : IRestaurantData
    {
        public InMemoryRestaurant()
        {
            _restaurants = new List<Restaurant>{
                new Restaurant{ Id = 1, Name = "Giorgio Pizza Place"},
                new Restaurant{ Id = 2, Name = "Italiano"},
                new Restaurant{ Id = 3, Name = "King Size Pizzas"}
            };
        }

        private List<Restaurant> _restaurants;

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }
    }
}
