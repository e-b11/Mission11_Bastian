using Microsoft.AspNetCore.Mvc;
using Mission11_Bastian.Models;
using System.Diagnostics;

namespace Mission11_Bastian.Controllers
{
    public class HomeController : Controller
    {
        public HomeController() { }

        public IActionResult Index()
        {
            return View();
        }

     
    }
}
