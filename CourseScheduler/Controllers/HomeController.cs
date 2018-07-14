using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CourseScheduler.Databases;

namespace CourseScheduler.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login()
        {
            UserDatabase userDatabase = new UserDatabase();
            string username = Request.Form["username"];
            Console.Write(username);
            string password = Request.Form["password"];

            if (userDatabase.AthenicateUser(username, password) != null)
            {
                return View("SuperAdminDashboard");
            }
            return View("Index");
        }
    }
}