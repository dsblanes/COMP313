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
        
        [HttpPost]
        public ActionResult Search(string JobQuery)
        {
            AutomationEntities_ j = new AutomationEntities_();
            var jobs = j.sp_jobstable().ToList();

            if (JobQuery == "" || !jobs.Contains(JobQuery)) 
            {
                return RedirectToAction("Sorry");
            }
            return RedirectToAction("Result","Home",new { OccupationQuery = JobQuery });
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

        public ActionResult Sorry()
        {
            ViewBag.Message = "Sorry";

            AutomationEntities_ j = new AutomationEntities_();
            var jobs = j.sp_jobstable().ToList();
            ViewBag.jobsInTable = jobs;

            return View();
        }

        public ActionResult Result(String OccupationQuery)
        {

        ViewBag.Message = "Results Page";

            AutomationEntities_ j = new AutomationEntities_();
            var jobs = j.sp_jobstable().ToList();
            ViewBag.jobsInTable = jobs;

            var jobsRelated = j.sp_Related(OccupationQuery).ToList();
            ViewBag.jobsRelatedTable = jobsRelated;

            var descrip = j.occDescription(OccupationQuery).FirstOrDefault();
            var prob = j.occProbability(OccupationQuery).FirstOrDefault();

            Occupation occ = new Occupation()
            {
                occName = OccupationQuery,
                occDescription = descrip,
                occProbability = prob
            };

            ViewData["OccupationData"] = occ;

            return View(occ);
        }
    }
}