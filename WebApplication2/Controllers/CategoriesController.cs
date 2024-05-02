using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers;

public class CategoriesController : Controller
{
    public static InfoContext db = new InfoContext();
    
    public CategoriesController()
    {
    }
    
    public ActionResult Categories(string id)
    {
        IEnumerable<Category> categories = db.Categories;
        
        ViewBag.Subcategory = categories
            .Where(it => it.Parent == id)
            .OrderBy(it => it.Sort);

        ViewBag.Category = categories
            .Where(it => it.ID == id)
            .SingleOrDefault();
            
        return View();
    }
}