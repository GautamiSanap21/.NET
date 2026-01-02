using Microsoft.AspNetCore.Mvc;
using ViewBag_ViewData_TempData.Models;

namespace ViewBag_ViewData_TempData.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            ViewBag.Title = "IndexMethod";
            return View();
        }

        public IActionResult Index2()
        {
            ViewData["msg"] = "Message from Index 2";
            return View();
        }

        public IActionResult Index3()
        {
            TempData["Name"] = "Bruce";
            return View();
        }
        public IActionResult Index4()
        {
            Emp emp = new Emp() { Id = 100, Name = "Gaurav", Address = "Indapur" };
            //if you use the viedata/viewbag/tempdata to pass the DataObject you have to use ViewData["Emp"]
            //ViewData["Emp"] = emp;


            //and if you directly pass DataObject from the View Method you have to use Model
            return View(emp);
        }

        
    }
}
