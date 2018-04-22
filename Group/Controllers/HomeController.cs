using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Group.Models;
using System.Data.Entity;


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

        public ActionResult Result(string OccupationQuery)
        {   
            //replace with OccupationQuery or aurgument passed from index
            string placeholder = "Clergy";

            ViewBag.Message = "Results Page";

            AutomationEntities_ j = new AutomationEntities_();
            var jobs = j.sp_jobstable().ToList();
            ViewBag.jobsInTable = jobs;

            var jobsRelated = j.sp_Related(placeholder).ToList();
            ViewBag.jobsRelatedTable = jobsRelated;

            var descrip = j.occDescription(placeholder).FirstOrDefault();
            var prob = j.occProbability(placeholder).FirstOrDefault();

            Occupation occ = new Occupation()
            {
                occName = placeholder,
                occDescription = descrip,
                occProbability = prob
            };

            ViewData["OccupationData"] = occ;

            return View(occ);
        }

        public ActionResult Sorry()
        {
            return View();
        }
    }
}