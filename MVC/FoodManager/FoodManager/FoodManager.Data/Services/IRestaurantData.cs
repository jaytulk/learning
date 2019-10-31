using System;
using System.Collections.Generic;
using System.Text;
using FoodManager.Data.Models;

namespace FoodManager.Data.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
        Restaurant GetById(int id);
        void Add(Restaurant restaurant);
        void Edit(Restaurant restaurant);
        void Remove(int id);
    }
}
