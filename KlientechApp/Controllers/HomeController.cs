using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KlientechApp.Models;

namespace KlientechApp.Controllers
{
    public class HomeController : Controller
    {
        ushanEntities db = new ushanEntities();
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public JsonResult GetEmployee(string text)
        {
            var data = db.Lucis.ToList();
            var emp = data.Where(e => e.FirstName.Contains(text)).Select(s => new { s.FirstName });
            return Json(emp, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetEmployees(string text)
        {
            var data = db.Lucis.ToList();
            var emp = data.Where(e => e.FullName.Contains(text)).Select(s => new { s.FullName });
            return Json(emp, JsonRequestBehavior.AllowGet);
        }
        
    }
}
