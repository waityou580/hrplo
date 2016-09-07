using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Globalization;
using System.Threading;
using HRPLO.Models;

namespace HRPLO.Areas.Login.Controllers
{
    public class LoginController : Controller
    {
        DBContext db = new DBContext();
        // GET: Login/Login
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Change(String LanguageAbbrevation)
        {
            if (LanguageAbbrevation != null)
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(LanguageAbbrevation);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(LanguageAbbrevation);
            }
            HttpCookie cookie = new HttpCookie("Language");
            cookie.Value = LanguageAbbrevation;
            Response.Cookies.Add(cookie);
            return View("Login");
        }
        [HttpPost]
        public ActionResult Submit(string username, string password)
        {
            USER usr = db.USERS.SingleOrDefault(n => n.USER_NAME == username && n.USER_PASS == password);
            if(usr != null)
            {
                Session["user"] = "admin";
                return RedirectToAction("Index", "Home",new {area = "AdminHome"}); // "AdminHome/Home"
            }
            return RedirectToAction("Login", "Login");
        }

        public ActionResult Logout()
        {
            Session["user"] = null; //Session.clear()
            return RedirectToAction("Login", "Login", new {area = "Login"});
        }
    }
}