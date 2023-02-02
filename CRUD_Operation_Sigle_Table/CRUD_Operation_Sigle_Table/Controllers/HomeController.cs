using CRUD_Operation_Sigle_Table.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CRUD_Operation_Sigle_Table.Controllers
{
    public class HomeController : Controller
    {
        ServiceContext db = new ServiceContext();
        [Authorize]
        public ActionResult Index()
        {
            var data = db.Employee.ToList();
            return View(data);
        }

        public ActionResult Create()
        {
             return View();
        }


        [HttpPost]
        public ActionResult Create(Employee e)
        {
            if (ModelState.IsValid == true)
            {
                db.Employee.Add(e);
                int a = db.SaveChanges();
                if (a > 0)
                {
                    ViewBag.CreateMassage = ("<script> alert('Data Saved ....')</script>");
                }
                else
                {
                    ViewBag.CreateMassage = ("<script> alert('Data  Not Saved ....')</script>");

                }
            }
            else
            {
                return View("AddValidDataView");
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Edit(Employee e)
        {

            db.Entry(e).State = EntityState.Modified;
            int a = db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult Edit(int ID)
        {

            Employee data = db.Employee.Where(m => m.Id == ID).FirstOrDefault();
            return View(data);
        }



        public ActionResult Delete(int ID)
        {

            Employee data = db.Employee.Where(m => m.Id == ID).FirstOrDefault();
            return View(data);
        }

        [HttpPost]
        public ActionResult Delete(Employee e)
        {

            db.Entry(e).State = EntityState.Deleted;
            int a = db.SaveChanges();
            if (a > 0)
            {
                ViewBag.DeleteMassage = ("<script> alert('Data Deleted ....')</script>");
                ModelState.Clear();
            }
            else
            {
                ViewBag.CreateMassage = ("<script> alert('Data  Not Deleted ....')</script>");

            }
            return RedirectToAction("Index");
        }



        public ActionResult Details(int ID)
        {

            Employee data = db.Employee.Where(m => m.Id == ID).FirstOrDefault();
            return View(data);
        }
    }
}