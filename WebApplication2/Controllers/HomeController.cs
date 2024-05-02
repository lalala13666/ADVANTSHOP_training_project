using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        public static InfoContext db = new InfoContext();
        
        public HomeController()
        {
        }
        
        public ActionResult Index()
        {
            IEnumerable<Product> products = db.Products;
        
            IEnumerable<Category> categories = db.Categories;
            
            ViewBag.Categories = categories.OrderBy(it => it.Sort);
            
            ViewBag.PopularCategories = categories
                .Where(it => it.Parent == null)
                .Take(6)
                .OrderBy(it => it.Sort);

            ViewBag.ThreeProducts = products.Take(3);
            
            ViewBag.PopularProducts = products
                .OrderByDescending(it => it.QuantitySold)
                .Take(3);
            
            return View();
        }
    }
}