using Microsoft.AspNetCore.Mvc;

namespace WebApp1.Controllers
{

    [Route("Home")]
    public class HomeController : Controller
    {
        //[Route("")]//if we use this, http://localhost:26565/Home it will directly display the WebPage byDefault
        //[Route("~/")]//if we use this, it will directly display the WebPage byDefault, we dont need to write Url explicitly

        //http://localhost:26565/Home/Index
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("Support")]
        public IActionResult Support()
        {
            return View();
        }

        [Route("About")]
        public IActionResult About()
        {
            return View();
        }

        [Route("Demo")]
        public IActionResult Demo()
        {
            //if Method name and view nae are different then pass the path of view with ~(tilde) operator
            return View("~/Views/Home/Test.cshtml");
        }



    }
}
