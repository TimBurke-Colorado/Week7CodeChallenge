using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Week7CodeChallenge.Controllers
{
    public class HomeController : Controller
    {
        // GET: Index
        public ActionResult Index()
        {
            if (Request.IsAjaxRequest())
                return PartialView();

            return View();
        }

        public ActionResult About()
        {            
                return PartialView();            
        }

        public ActionResult Careers()
        {
            return PartialView();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return PartialView();
        }

        [HttpPost]
        public ActionResult Contact(Models.Week7ChallengeContactsTable contact)
        {
            Models.sp6TimEntities2 db = new Models.sp6TimEntities2();

            db.Week7ChallengeContactsTable.Add(contact);
            db.SaveChanges();

            return Content("Thank you for contacting us!");
        }

        public ActionResult Work()
        {
            return PartialView();
        }
        
    }
}