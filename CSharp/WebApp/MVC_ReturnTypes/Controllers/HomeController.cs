using Microsoft.AspNetCore.Mvc;
using System.Collections;

namespace MVC_ReturnTypes.Controllers
{
    public class HomeController : Controller
    {

        // Most Flexible ReturnType : Comman Type
        public IActionResult Index()
        {
            return View();
        }


        // Most common Return Type in old MVC version(Standard .Net)
        public ActionResult About()
        {
            return View();
        }


        // Strongly -typed return type of Method : Generic Type<T>
        public ActionResult<int> GetNumber()
        {
            return 1209;
        }

        //ViewResult is innherited from ActionResult. ViewResult used only for views
        public ViewResult Method1()
        {
            return View("~/Views/Home/About.cshtml");
        }



        //http://localhost:51786/home/GetData?unm=abc&pwd=123
        public string GetData(string unm, string pwd) {

            return $"UserName = {unm} passWord = {pwd}";
        }


        public JsonResult GetJSON()
        {
            //Anonymous Object
            var data = new
            {
                ID = 01,
                Name = "Gana Sir",
                Address = "PG"
            };
            //it will first convert object into JSON object and return it
             return Json(data);
        }


        public ObjectResult GetObj()
        {
            var obj = new {
            Id = 01,
            Name = "Gana Sir",
            Address = "PG"
            };

            return new ObjectResult(obj);
        }


        public StatusCodeResult GetStatus()
        {
            return StatusCode(200);
        }


        public EmptyResult DoNothing()
        {
            return new EmptyResult();
        }

        public async Task<ViewResult> GetResult()
        {
            await Task.Delay(5000);
            return View("~/Views/Home/GetJSON.cshtml");
        }

        public FileResult DownloadFile()
        {
            var byteArray = System.IO.File.ReadAllBytes(@"C:/Users/IET/Desktop/250845920024/CSharp/WebApp/MVC_ReturnTypes/Data/quote.pdf");

            return File(byteArray, "application/pdf", "quote.pdf");
        }


        public async Task<ViewResult> TaskView()
        {
            await Task.Delay(5000);
            return View("~/Views/Home/About.cshtml");
        }


        public FileResult DownloadFiles()
        {
            var byteArray = System.IO.File.ReadAllBytes(@"C:\Users\IET\Desktop\250845920024\CSharp\WebApp\MVC_ReturnTypes\Data\quote.pdf");

            return File(byteArray, "application/pdf", "quote.pdf");
        }



    }
}
