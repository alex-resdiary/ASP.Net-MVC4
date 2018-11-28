using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace OdeToFood
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {

            //this is used to ignore/not allow access to files/folders of web application
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //the order of routes in mapping engine is signficant
            //the first route to match URL will win


            routes.MapRoute("Cuisine",
                "cuisine/{name}",
                new { controller = "Cuisine", action = "Search", name =UrlParameter.Optional  //OR name = ""  , default value if nothing is passed to the URL
                });


            //default parameter values makes this url very greedy as it will defalt this very often
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
