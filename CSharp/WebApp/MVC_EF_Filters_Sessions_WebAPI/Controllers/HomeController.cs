using Microsoft.AspNetCore.Mvc;
using MVC_EF_Filters_Sessions_WebAPI.Models;

namespace MVC_EF_Filters_Sessions_WebAPI.Controllers
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
            return View();
        }
    }
}
