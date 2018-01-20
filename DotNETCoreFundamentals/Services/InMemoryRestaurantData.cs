using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DotNETCoreFundamentals.Models;

namespace DotNETCoreFundamentals.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant{ Id = 1, Name = "Scott's  Pizza Place"},
                new Restaurant{ Id = 2, Name = "MacDonal"},
                new Restaurant{ Id = 3, Name = "Papa Chicken"}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }

        public Restaurant Get(int id)
        {
            return _restaurants.FirstOrDefault(r => r.Id == id);
        }

        List<Restaurant> _restaurants;
    }

}
