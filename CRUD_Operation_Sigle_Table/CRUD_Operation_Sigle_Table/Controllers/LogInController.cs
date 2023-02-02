using CRUD_Operation_Sigle_Table.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace CRUD_Operation_Sigle_Table.Controllers
{
    public class LogInController : Controller
    {
        ServiceContext db = new ServiceContext();
        // GET: LogIn
        public ActionResult LogInMethod()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LogInMethod(UserLogIn e)
        {

            db.UserLogIn.Add(e);    
            db.SaveChanges();   
             
            return View();
        }

        public ActionResult LogInNevigation()
        {

            return View();
        }

        [HttpPost]
        public ActionResult LogInNevigation(UserLogIn e)
        {

            var data = db.UserLogIn.Where(c => c.UserName == e.UserName && c.Password == e.Password );
            if (data != null)
            {
                FormsAuthentication.SetAuthCookie(e.UserName, false);
                return RedirectToAction( "Index" , "Category");   

            }
            return RedirectToAction("LogInNevigationFail");
        }

    }
}