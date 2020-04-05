using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SchoolSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult InternalHome()
        {
            return View();
        }
        public ActionResult Transparecia()
        {
            return View();
        }
         public ActionResult InfoAdmi()	
        {	        
            return View();	          
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Materias()
        {
            return View();
        }

    }
}