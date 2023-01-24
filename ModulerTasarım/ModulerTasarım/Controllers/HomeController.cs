using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ModulerTasarım.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.data = new List<string>  { "img1.jpg", "img2.jpg", "img3.jpg " };

            object o = new object();
            return View(o);
        }
        public IActionResult Privacy()
        {
            return View();
        }
    }
}
