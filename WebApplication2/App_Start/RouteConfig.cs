using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace WebApplication2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            
            routes.MapRoute(
                name: "CategoriesRoute",
                url: "Categories/{action}/{id}",
                defaults: new { controller = "Categories", action = "Categories", id = UrlParameter.Optional }
            );
            
            routes.MapRoute(
                name: "ProductsRoute",
                url: "Products/{action}/{id}",
                defaults: new { controller = "Products", action = "Products", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}