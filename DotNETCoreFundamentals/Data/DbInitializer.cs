using DotNETCoreFundamentals.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNETCoreFundamentals.Data
{
    public static class DbInitializer
    {
        public static void Initialize(OdeToFoodDbContext context)
        {
            context.Database.EnsureCreated();
            if (context.Restaurants.Any())
            {
                return;
            }

            var restaurants = new List<Restaurant>
            {
                new Restaurant{  Name = "Scott's  Pizza Place", Cuisine = CuisineType.Italian},
                new Restaurant{ Name = "Wrap And Roll", Cuisine = CuisineType.French},
                new Restaurant{ Name = "Papa's Chicken", Cuisine = CuisineType.German}
            };

            context.Restaurants.AddRange(restaurants);
            context.SaveChanges();
        }

    }
}
