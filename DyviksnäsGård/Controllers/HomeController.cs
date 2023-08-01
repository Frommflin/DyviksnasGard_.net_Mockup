using DyviksnäsGård.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DyviksnäsGård.Controllers
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
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult AllHorses()
        {
            return View();
        }

        public IActionResult GoToInstagram()
        {
            return Redirect("https://www.instagram.com/dyviksnas_gard/");
        }

        public IActionResult GoToFacebook()
        {
            return Redirect("https://www.facebook.com/pages/Dyviksn%C3%A4s%20G%C3%A5rd/102500191339544");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}