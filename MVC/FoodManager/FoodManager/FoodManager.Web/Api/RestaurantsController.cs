using System.Collections.Generic;
using System.Web.Http;
using FoodManager.Data.Models;
using FoodManager.Data.Services;

namespace FoodManager.Web.Api
{
    public class RestaurantsController : ApiController
    {
        private readonly IRestaurantData _db;

        public RestaurantsController(IRestaurantData db)
        {
            _db = db;
        }

        public IEnumerable<Restaurant> Get()
        {
            return _db.GetAll();
        }
    }
}
