using Ado.NetCategoryProductProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ado.NetCategoryProductProject.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        DataBase db = new DataBase();   
        public ActionResult Index()
        {
            List<Category> list =  db.GetCategories().ToList(); 
            return View(list);
        }
    }
}