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
    }
}
