using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UnitWebApplication.Models;
using UnitWebApplicationBLL.Intercafes;

namespace UnitWebApplication.Controllers
{
    public class HomeController : Controller
    {
        // private readonly ILogger _logger;
        IRepository _repository;
        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var users = _repository.GetAll();
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
