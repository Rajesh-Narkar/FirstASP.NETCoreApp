using Microsoft.AspNetCore.Mvc;
using MayBatch1AspCoreApp.Models;

namespace MayBatch1AspCoreApp.Controllers
{
    public class ViewController : Controller
    {
        public IActionResult Index()
        {
            var e = new List<Emp>()
            {
                new Emp() { Id = 101, Name = "John", Salary = 2000 },
                new Emp() { Id = 102, Name = "Rocky", Salary = 4000 },
                new Emp() { Id = 103, Name = "Robin", Salary = 1000 },
                new Emp() { Id = 104, Name = "Jack", Salary = 5000 }
            };
            ViewBag.obj = e;
            
            return View();

        }

        public IActionResult ViewDataPage()
        {
            var e = new List<Emp>()
            {
                new Emp() { Id = 101, Name = "John", Salary = 2000 },
                new Emp() { Id = 102, Name = "Rocky", Salary = 4000 },
                new Emp() { Id = 103, Name = "Robin", Salary = 1000 },
                new Emp() { Id = 104, Name = "Jack", Salary = 5000 }
            };

            ViewData["obj"] = e;
            return View();

        }

        public IActionResult TempDataPage()
        {
            var e = new List<Emp>()
            {
                new Emp() { Id = 101, Name = "John", Salary = 2000 },
                new Emp() { Id = 102, Name = "Rocky", Salary = 4000 },
                new Emp() { Id = 103, Name = "Robin", Salary = 1000 },
                new Emp() { Id = 104, Name = "Jack", Salary = 5000 }
            };

            TempData["obj"] = e;
            return View();

        }

    }
}
