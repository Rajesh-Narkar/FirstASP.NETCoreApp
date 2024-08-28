using MayBatch1AspCoreApp.Data;
using MayBatch1AspCoreApp.Models;
using MayBatch1AspCoreApp.Repo;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MayBatch1AspCoreApp.Controllers
{
    
    public class AuthController : Controller
    {
        //private readonly ApplicationDbContext db;
        //public AuthController(ApplicationDbContext db) 
        //{ 
        //    this.db=db;
        //}
        UserRepo repo;
        private readonly ApplicationDbContext db;
        public AuthController(UserRepo repo, ApplicationDbContext db)
        {
            this.repo = repo;
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(User us)
        {
            repo.SignUp(us);
            TempData["success"] = "User Registred Successfully";
            return RedirectToAction("Signin");
        }

        public IActionResult Signin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signin(Login log)
        {
            var data = db.users.Where(x => x.Username.Equals(log.Username) && x.Password.Equals(log.Password)).SingleOrDefault();
            if (data != null)
            {
                var identity = new ClaimsIdentity(new[] { new Claim(ClaimTypes.Name, data.Username) }, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal=new ClaimsPrincipal(identity);
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);
                HttpContext.Session.SetString("Username", data.Username);
                return RedirectToAction("Index", "DB");
            }
            else
            {
                TempData["error"] = "Invalid Credentials!!";
                return RedirectToAction("SignIn");
            }
        }

        public IActionResult SignOut()
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            var storedcookies = Request.Cookies.Keys;
            foreach (var cookie in storedcookies)
            {
                Response.Cookies.Delete(cookie);
            }
            return RedirectToAction("SignIn");
        }
    }
}