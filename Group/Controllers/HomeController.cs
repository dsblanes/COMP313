using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Group.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "About This Project";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Contact SCPS";

            return View();
        }

        public ActionResult Result()
        {
            ViewBag.Message = "Results Page";

            return View();
        }

        public ActionResult Sorry()
        {
            return View();
        }
    }
}