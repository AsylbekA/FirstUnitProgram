using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UnitWebApplication.Models;

namespace UnitWebApplication.Controllers
{
    public class HomeController : Controller
    {
       // private readonly ILogger _logger;
        public HomeController()
        {

        }

        public IActionResult Index()
        {
            ViewData["Message"] = "Hello world!";
            return View("Index");
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
