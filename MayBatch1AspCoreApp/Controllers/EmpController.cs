using Microsoft.AspNetCore.Mvc;
using MayBatch1AspCoreApp.Models;
namespace MayBatch1AspCoreApp.Controllers
{
    public class EmpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Emp e)
        {
            if (ModelState.IsValid)
            {
                return View(e);
            }
            else
            {
                return View();
            }
            
        }
    }
}
