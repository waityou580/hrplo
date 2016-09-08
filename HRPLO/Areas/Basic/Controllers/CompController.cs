using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HRPLO.Models;

namespace HRPLO.Areas.Basic.Controllers
{
    public class CompController : Controller
    {
        DBContext db = new DBContext();
        // GET: Basic/Comp
        public ActionResult Comp_Index()
        {
            List_Comp();
            return View();
        }
        [HttpPost]
        public ActionResult Creat_Comp(string Comp_No,string Comp_Name,string Comp_CN, string INV_ADD, string Comp_Boss, string Comp_Tel, string Comp_Fax, string Comp_Mail)
        {
            EM_COMP em_comp = new EM_COMP();
            em_comp.COMP_NO = Comp_No;
            em_comp.COMP_NAME = Comp_Name;
            em_comp.COMP_CN = Comp_CN;
            em_comp.INV_ADD = INV_ADD;
            em_comp.COMP_BOSS = Comp_Boss;
            em_comp.COMP_TEL = Comp_Tel;
            em_comp.COMP_FAX = Comp_Fax;
            em_comp.COMP_MAIL = Comp_Mail;
            em_comp.IS_ACT = true;
            em_comp.DO_TIME = DateTime.Now.ToString();
            //em_comp.DO_USER = Session["user"].ToString();

            //db.EM_COMP.Add(em_comp);
            //db.SaveChanges();
            ViewBag.Message = HRPLO.Resources.Global.Create_Success;
            return View("Comp_Index");
        }
        public ActionResult List_Comp()
        {
            List<EM_COMP> lst_Comp =  db.EM_COMP.Take(10).ToList();
            return View(lst_Comp);
        }
    }
}