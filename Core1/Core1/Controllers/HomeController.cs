using Core1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Core1.Controllers
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
            ViewBag.Name = "I Love my Family";
            ViewBag.Age = 22;
            ViewBag.Date_and_time = DateTime.Now;
            ViewBag.Salary = 50000;
            ViewBag.group = new List<string>()
            {
                "Radha",
                "Rani",
                "Umma"
            };

            ViewData["Name"] = "I Love my Family";
            ViewData["Age"] = 22;
            ViewData["Date_and_time"] = DateTime.Now;
            ViewData["Salary"] = 50000;
            ViewData["group"] = new List<string>()
            {
                "Radha",
                "Rani",
                "Umma"
            };

            TempData["Name"] = "Hello Friend";
            TempData["Age"] = 25;
            TempData["Date_and_time"] = DateTime.Now;
            TempData["Salary"] = 20000;
            TempData["group"] = new List<string>()
            {
                "Vikash",
                "Shivam",
                "Rohit Gupta"
            };

            HttpContext.Session.SetString("Name", "Neelam");
            ViewBag.session = HttpContext.Session.GetString("Name");
            return View();
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
    }
}
