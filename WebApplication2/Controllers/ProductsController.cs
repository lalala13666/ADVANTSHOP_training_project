using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers;

public class ProductsController : Controller
{
    public static InfoContext db = new InfoContext();
    
    public ProductsController()
    {
    }
    
    public ActionResult Products(string id)
    {
        IEnumerable<Product> products = db.Products;
        
        IEnumerable<Category> categories = db.Categories;
        
        ViewBag.Products = products
            .Where(it => it.Category == id);

        ViewBag.Category = categories
            .Where(it => it.ID == id)
            .SingleOrDefault();
        
        ViewBag.Subcategory = categories
            .Where(it => it.Parent == ViewBag.Category.Parent)
            .OrderBy(it => it.Sort);
            
        return View();
    }
}