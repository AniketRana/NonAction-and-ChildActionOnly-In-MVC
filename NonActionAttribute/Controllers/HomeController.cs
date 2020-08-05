using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
//using System.Reflection;

namespace NonActionAttribute.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        //method 2 to restrict URL request from browser 
        //[NonAction]  
        public ActionResult About() 
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        //method 1 to restrict URL request from browser 
        //private ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        [ChildActionOnly]
        public PartialViewResult Aniket()
        {
            return PartialView("_Aniket");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}