using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KlientechApp.Models;

namespace KlientechApp.Controllers
{
    public class EmployeeController : Controller
    {

        ushanEntities db = new ushanEntities();
        // GET: Employee
        public ActionResult Index()

        {
            var names = db.Lucis.ToList();
            List<SelectListItem> items = new List<SelectListItem>();

            SelectListItem item3 = new SelectListItem() { Text = " ", Value = "0", Selected = true };
            SelectListItem item1 = new SelectListItem() { Text ="Married" , Value="1",Selected=true};
            SelectListItem item2 = new SelectListItem() { Text = "Single", Value = "1", Selected = true };
            
            items.Add(item1);
            items.Add(item2);

            ViewBag.Action2 = items;

            return View(db.Lucis.ToList());
        }
        [HttpPost]
        public ActionResult Create(Luci employee)
        {
            string message = "Saved Successfully";
            bool status = true;
            db.Lucis.Add(employee);
            db.SaveChanges();
            return Json(new { status = status, message = message, id = db.Lucis.Max(x => x.ID) }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetEmployee(int ID)
        {
            Luci data = new Luci();
            var getEmp = db.Lucis.Where(x => x.ID == ID).FirstOrDefault();
            data.ID = getEmp.ID;
            data.FirstName = getEmp.FirstName;
            data.LastName = getEmp.LastName;
            data.DateOfBirth = getEmp.DateOfBirth;
            data.Telephone = getEmp.Telephone;
            data.Address1 = getEmp.Address1;
            data.Address2 = getEmp.Address2;
            data.Action = getEmp.Action;
            data.Age = getEmp.Age;
            
            return Json(new { success = true, data = data }, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult CreateS(Luci employee)
        {
            string message = "Saved Successfully";
            bool status = true;
            db.Lucis.Add(employee);
            db.SaveChanges();
            return Json(new { status = status, message = message, id = db.Lucis.Max(x => x.ID) }, JsonRequestBehavior.AllowGet);
        }

    }
    }