using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            /*var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            var id = RouteData.Values["id"];

            var message = String.Format("{0}::{1} {2}", controller, action, id);
            */
            var model = new AboutModel
            {
                Name = "Alex Cleary",
                Location = "Nicosia, Cyprus"
            };

            ViewBag.Title = "Home Page";
            ViewBag.Location = "nicosia,Cyprus";

            return View(model);
        }

        public ActionResult About()
        {
            var model = new AboutModel();
            ViewBag.Title = "About Page";
            model.Name = "Alex Cleary";
            model.Location = "Glasgow,Scotland";
            return View(model);
        }

    }
}
