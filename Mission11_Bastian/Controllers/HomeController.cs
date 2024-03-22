using Microsoft.AspNetCore.Mvc;
using Mission11_Bastian.Models;
using Mission11_Bastian.Models.ViewModels;
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

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10; //Set page size to 10 items per page

            //Get a new BookListViewModel object, and then set up the each of the models inside there
            var data = new BookListViewModel
            {
                Books = _repo.Books
                    .OrderBy(x => x.Title)
                    .Skip((pageNum - 1) * pageSize) //Skip items depending on what page you're on
                    .Take(pageSize),

                PaginationInfo = new PaginationInfo //Set up info for pagination
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };

            return View(data);
        }

     
    }
}
