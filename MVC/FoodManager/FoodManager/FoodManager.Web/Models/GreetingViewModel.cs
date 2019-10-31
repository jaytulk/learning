using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FoodManager.Data.Models;

namespace FoodManager.Web.Models
{
    public class GreetingViewModel
    {
        public IEnumerable<Restaurant> Restaurants { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
    }
}