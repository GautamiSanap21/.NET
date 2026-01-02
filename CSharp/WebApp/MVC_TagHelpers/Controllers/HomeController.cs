using Microsoft.AspNetCore.Mvc;
using MVC_TagHelpers.Models;

namespace MVC_TagHelpers.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetNewUserDetails(NewUser newuser)
        {
            return View(newuser);
        }
    }
}
