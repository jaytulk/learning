using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FoodManager.Web.Models;

namespace FoodManager.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index(string name)
        {
            var model = new GreetingViewModel
            {
                Name = name ?? "No Name",
                Message = ConfigurationManager.AppSettings["message"]
            };
            return View(model);
        }
    }
}