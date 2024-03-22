using Microsoft.AspNetCore.Mvc;
using Mission11_Bastian.Models;
using System.Diagnostics;

namespace Mission11_Bastian.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository _repo;
        public HomeController(IBookRepository temp) 
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

     
    }
}
