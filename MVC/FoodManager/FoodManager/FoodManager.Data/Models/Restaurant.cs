using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace FoodManager.Data.Models
{
    public class Restaurant
    {
        public int Id { get; set; }

        [Required, MaxLength(10)]
        public string Name { get; set; }

        [Display(Name="Type of food")]
        public CuisineType Cuisine { get; set; }
    }
}
