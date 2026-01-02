using Microsoft.AspNetCore.Mvc;
using ViewBag_ViewData_TempData.Models;

namespace ViewBag_ViewData_TempData.Controllers
{
    public class DemoController : Controller
    {
        List<Emp> emplist = new List<Emp>()
        {
            new Emp(){Id = 01, Name = "Amit", Address = "Pune"},
            new Emp(){Id = 02, Name = "Sumit", Address = "Nashik"},
            new Emp(){Id = 03, Name = "Rahul", Address = "Satara"},
            new Emp(){Id = 04, Name = "Rohit", Address = "Thane"},
            new Emp(){Id = 05, Name = "Vijay", Address = "Pune"}

        };

        List<Customer> clist = new List<Customer>()
        {
            new Customer(){CId = 101, Name = "C1", Address = "LA", BillNo = 1000},
            new Customer(){CId = 102, Name = "C2", Address = "NA", BillNo = 1001},
            new Customer(){CId = 103, Name = "C3", Address = "NA", BillNo = 1002},
            new Customer(){CId = 104, Name = "C4", Address = "LA", BillNo = 1003},
            new Customer(){CId = 105, Name = "C5", Address = "LA", BillNo = 1004},
        };

        public IActionResult Index()
        {
            Combine cb = new Combine();
            cb.MyEmp = emplist;
            cb.MyCustomer = clist;

            return View(cb);
        }
    }
}
