using Drinks_Machine.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Drinks_Machine.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(new CoffeeModel("Customer Name", "Size"));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


//DrinkList - Ajax Response
        [HttpGet]
        public IActionResult DrinkList()
        {
            return Json(new HotDrinkModel().NameList);
        }
//Recipe List - Ajax Response


        [HttpGet]
        public IActionResult RecipeList([FromQuery] string drink)
        {

            if (drink == "Coffee")
                return Json(new CoffeeModel().Recipe);

            if (drink == "Chocolate")
                return Json(new ChocolateModel().Recipe);

            if (drink == "Lemon Tea")
                return Json(new LemonTeaModel().Recipe);

            return Json("Drink Not Available");
        }
    }
}

