using System.Data.Entity;
using FoodManager.Data.Models;

namespace FoodManager.Data.Services
{
    public class FoodManagerDbContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}