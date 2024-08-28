using MayBatch1AspCoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MayBatch1AspCoreApp.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            var e = new Emp()
            {
                Id = 101,
                Name="John",
                Salary=12000
            };

            return View(e);
        }
        public IActionResult EmpsData()
        {
            var e = new List<Emp>()
            {
                new Emp() { Id = 101, Name = "John", Salary = 2000 },
                new Emp() { Id = 102, Name = "Rocky", Salary = 4000 },
                new Emp() { Id = 103, Name = "Robin", Salary = 1000 },
                new Emp() { Id = 104, Name = "Jack", Salary = 5000 }
            };
            return View(e);
        }
        public IActionResult MgrData()
        {
            var m = new List<Mgr>()
            {
                new Mgr() { MgrId = 1, MgrName = "John", MgrSalary = 2000 },
                new Mgr() { MgrId = 2, MgrName = "Rocky", MgrSalary = 4000 },
                new Mgr() { MgrId = 3, MgrName = "Robin", MgrSalary = 1000 },
                new Mgr() { MgrId = 4, MgrName = "Jack", MgrSalary = 5000 }
            };
            return View(m);
        }
        public IActionResult Details()
        {
            var emps = new List<Emp>()
            {
                new Emp() { Id = 101, Name = "John", Salary = 2000 },
                new Emp() { Id = 102, Name = "Rocky", Salary = 4000 },
                new Emp() { Id = 103, Name = "Robin", Salary = 1000 },
                new Emp() { Id = 104, Name = "Jack", Salary = 5000 }
            };

            var mgrs = new List<Mgr>()
            {
                new Mgr() { MgrId = 01, MgrName = "Ram", MgrSalary = 20000 },
                new Mgr() { MgrId = 02, MgrName = "Sham", MgrSalary = 40000 },
                new Mgr() { MgrId = 03, MgrName = "Sita", MgrSalary = 10000 },
                new Mgr() { MgrId = 04, MgrName = "Gita", MgrSalary = 50000 }
            };

            var viewModel = new AllDetails()
            {
                Employees = emps,
                Managers = mgrs
            };

            return View(viewModel);
        }

        public string Display(string name,int age,string place)
        {
            return "Your Name is " + name+" and age is "+age+". You live at "+place;
        }
    }
}
