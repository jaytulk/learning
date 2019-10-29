using System.Collections.Generic;
using System.Linq;
using FoodManager.Data.Models;

namespace FoodManager.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        private readonly List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>
            {
                new Restaurant{ Id = 1, Name = "Pizza", Cuisine = CuisineType.Italian},
                new Restaurant{ Id = 2, Name = "Cafe", Cuisine = CuisineType.French},
                new Restaurant{ Id = 3, Name = "Bay Leaves", Cuisine = CuisineType.Indian},
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(x=> x.Name);

        }

        public Restaurant GetById(int id)
        {
            return _restaurants.FirstOrDefault(x => x.Id == id);
        }
    }
}