using MayBatch1AspCoreApp.Data;
using MayBatch1AspCoreApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MayBatch1AspCoreApp.Controllers
{
    [Authorize]
    public class DBController : Controller
    {
        ApplicationDbContext db;
        public DBController(ApplicationDbContext adc) { 
        db= adc;
        }
        public IActionResult Index()
        {
            var obj = db.emps.ToList();
            return View(obj);
        }
        [AllowAnonymous]
        public IActionResult AddEmp()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult AddEmp(Emp e) 
        {
            db.emps.Add(e);
            db.SaveChanges();
            return RedirectToAction("Index");


        }

        public IActionResult UpdateEmp(int id)
        {
            var data = db.emps.Find(id);
            return View(data);
        }

        [HttpPost]
        public IActionResult ModifyEmp(Emp e) 
        
        {
            db.emps.Update(e);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult DeleteEmp(int id) {
            
            if(id != null)
            {
               var data =  db.emps.Find(id);
                db.emps.Remove(data);
                db.SaveChanges ();
            }

            return RedirectToAction("Index");
        
        }


    }
}
