using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRPLO.Areas.AdminHome.Controllers
{
    public class HomeController : Controller
    {
        // GET: AdminHome/Home
        public ActionResult Index()
        {
            if (Session["user"] == null)
            {
                return RedirectToAction("Login", "Login", new {area="Login"});
            }
            return View();
        }
    }
}