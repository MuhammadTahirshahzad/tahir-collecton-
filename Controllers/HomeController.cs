using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using tahircollection.Models;

namespace tahircollection.Controllers
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


        public IActionResult Index1(string fanme, string lname,string email,string phone,string gender,string department)
        {
            if(fanme =="text" && email == "email")
            {
                ViewBag.message = "data racived";

            }
            else
            {
                ViewBag.message = "data not racived";

            }
            return View("Index1");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}