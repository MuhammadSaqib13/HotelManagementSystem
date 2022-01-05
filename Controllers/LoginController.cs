using Hotel_MS.DBContext;
using Hotel_MS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Hotel_MS.Controllers
{
    public class LoginController : Controller
    {
        AppDBContext db = new AppDBContext();
        // GET: Login
        public ActionResult AdminLogin()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminLogin(System_Admin log)
        {
            var Validuser = db.System_Admins.Where(x => x.Name == log.Name && x.Password == log.Password).FirstOrDefault();
            if (Validuser != null)
            {
                //Validuser.
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("", "Invalid USername and Password");
            return View();
        }
    }
}