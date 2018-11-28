using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        // GET: Cuisine
        [HttpPost]
        public ActionResult Search(string name) //can set default value by doing (string name="french" )
        {
            //server is a property that gets inherited from controller to get to server type properite
            //htmlencode prevents a Cross Site Scripting attack as it takes any user input 
            //or URL info and renders it as text

            var message = Server.HtmlEncode(name);





             return Content("<h1>Hello " + RouteData.Values["name"] + "</h1>");
            //or
            // return Content(message);
        }
    }
}