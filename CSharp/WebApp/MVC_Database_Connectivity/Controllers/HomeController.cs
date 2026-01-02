using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_Database_Connectivity.Models;

namespace MVC_Database_Connectivity.Controllers
{
    public class HomeController : Controller
    {
        private DatabaseContext _databaseContext;

        public HomeController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }
        public IActionResult GetAllStudents()
        {
            List<Student> list = _databaseContext.getAllStudents();
            return View(list);
        }
    }
}
