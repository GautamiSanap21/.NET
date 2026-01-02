using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
        public IActionResult Support()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        //it will accept parameters from URL
        public string GetName(string name)
        {
            return $"{name} and ...";
        }


    }
}
