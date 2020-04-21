using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace cis237_assignment6.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.MyJumbotron = "Welcome to the Beverage Program! We have a variety of options to pick from. Click the about page for more info, contact for contacting us, and Beverage for our full list.";

            return View();
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Beverages()
        {
            ViewBag.Message = "Your Beverages page.";

            return View();
        }
    }
}