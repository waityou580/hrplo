﻿using System;
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
            return View(username);
        }
    }
}