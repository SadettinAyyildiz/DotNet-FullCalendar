using DentistCalendar.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DentistCalendar.Controllers
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

            //Redirect ile
            //return Redirect("/home/deneme");

            //Aynı Controller içinde redirect
            //return RedirectToAction("Deneme");

            //Fareklı Controller için redirect -> ikinci parametre olarak hangi Controller olduğu geçilir
            //return RedirectToAction("Deneme", "Home"); 

        }

        // Json dönmek için - Deneme2 çağırıldığında Json döner
        public JsonResult Deneme2()
        {
            //işlemler
            return Json("data");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Deneme()
        {
            List<string> colors = new List<string>() { "Blue", "Yellow" };
            DenemeViewModel model = new DenemeViewModel()
            { 
                Colors = colors
            };

            return View(model); //--> Views altında Deneme yi çağırır
            //return View("Index"); //--> Views altında Indeks i çağırır
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
