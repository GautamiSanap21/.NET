using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        //http://localhost:34727/home/index
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("[Action]")]
        public IActionResult Contact()
        {
            return View();
        }

        //http://localhost:34727/home/support
        [Route("[Action]")]
        public IActionResult Support()
        {
            return View();
        }

        [Route("[Action]")]
        public IActionResult About()
        {
            return View();
        }

        //it will accept parameters from URL
        //http://localhost:34727/home/GetName?name=gana
        [Route("[Action]")]
        public string GetName(string name)
        {
            return $"{name} and ...";
        }


    }
}
