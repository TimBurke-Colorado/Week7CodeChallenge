﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Week7CodeChallenge.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult Who()
        {
            return PartialView();
        }

        public ActionResult What()
        {
            return PartialView();
        }

        public ActionResult Why()
        {
            return PartialView();
        }

        public ActionResult How()
        {
            return PartialView();
        }

        public ActionResult Where()
        {
            return PartialView();
        }
    }
}