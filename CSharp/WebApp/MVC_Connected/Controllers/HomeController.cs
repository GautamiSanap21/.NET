using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Connected.Models;

namespace MVC_Connected.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataContext _dataContext;

        public HomeController(DataContext context)
        {
            _dataContext = context;
        }
 
        public IActionResult Index()
        {
            var allEmps = _dataContext.GetAllEmps();
            return View(allEmps);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
