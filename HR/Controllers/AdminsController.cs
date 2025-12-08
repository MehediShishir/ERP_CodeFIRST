using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HR.Models;

namespace HR.Controllers
{
    public class AdminsController : Controller
    {
        HRContext db = new HRContext();

        // Login page
        public ActionResult Index()
        {
            return View();
        }

        // Handle Login
        [HttpPost]
        public ActionResult Index(string username, string password)
        {
            var admin = db.Admins
                          .FirstOrDefault(a => a.UserName == username
                                            && a.Password == password);

            if (admin != null)
            {
                Session["AdminUser"] = admin.UserName;

                // After successful login → go to Home page
                return RedirectToAction("Index", "Home");
            }

            ViewBag.Error = "Invalid Username or Password";
            return View();
        }

        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index");
        }


    }
}