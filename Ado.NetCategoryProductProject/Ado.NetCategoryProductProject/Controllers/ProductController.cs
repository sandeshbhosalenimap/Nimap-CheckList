using Ado.NetCategoryProductProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ado.NetCategoryProductProject.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        DataBase db = new DataBase();
        public ActionResult ListOfProduct(int CategoryId)
        {
            var products = db.Getproducts().Where(c => c.CategoryId == CategoryId).ToList();
          
            return View(products);
        }

       
    }
}