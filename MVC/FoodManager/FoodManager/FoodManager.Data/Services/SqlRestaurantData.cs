using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using FoodManager.Data.Models;

namespace FoodManager.Data.Services
{
    public class SqlRestaurantData:IRestaurantData
    {
        private FoodManagerDbContext _db;

        public SqlRestaurantData(FoodManagerDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _db.Restaurants.OrderBy(x => x.Name);
        }

        public Restaurant GetById(int id)
        {
            return _db.Restaurants.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Restaurant restaurant)
        {
            _db.Restaurants.Add(restaurant);
            _db.SaveChanges();
        }

        public void Edit(Restaurant restaurant)
        {
            var entry = _db.Entry(restaurant);

            entry.State = EntityState.Modified;

            _db.SaveChanges();

        }

        public void Remove(int id)
        {
            var match = _db.Restaurants.Find(id);
            if (match != null)
            {
                _db.Restaurants.Remove(match);
                _db.SaveChanges();
            }
        }
    }
}
