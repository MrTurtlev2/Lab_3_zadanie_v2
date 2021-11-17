using lab3_test.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace lab3_test.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(int id)
        {
            ViewData["p1"] = id;
            return View();
        }

        public IActionResult Test2(int id, int? param2, int param3 = 30, int param4 = 40)
        {
            ViewData["id"] = id;
            ViewData["p2"] = param2;
            ViewData["p3"] = param3;
            ViewData["p4"] = param4;
            return View();
        }

        [Route("Home/Tescik3")]

        public IActionResult Test3()
        {
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
