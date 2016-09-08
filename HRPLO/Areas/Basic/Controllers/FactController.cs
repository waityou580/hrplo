using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HRPLO.Areas.Basic.Controllers
{
    public class FactController : Controller
    {
        // GET: Basic/Fact
        public ActionResult Fact_Index()
        {
            return View();
        }
    }
}