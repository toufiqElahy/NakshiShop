using Microsoft.AspNetCore.Mvc;
using NakshiShop.Models;
using System.Diagnostics;

namespace NakshiShop.Controllers
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
            var lstVideo = ListVideo.Videoes();
            ViewBag.Videoes = lstVideo;
            return View();
        }
        public IActionResult Video(decimal price)
        {
            var lstVideo = ListVideo.Videoes();
            var model = lstVideo.FirstOrDefault(x => x.Price == price);
            return Json(model);
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