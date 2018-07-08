﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace MVC5Course.Controllers
{
    public class ARController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ViewTest()
        {
            string model = "My Data";
            return View((object)model);
        }

        public ActionResult PartialViewTest()
        {
            string model = "My Data";
            return PartialView("ViewTest", (object)model);
        }

        public ActionResult ContentTest()
        {
            return Content("Test Content!", 
                "text/plain", 
                Encoding.GetEncoding("Big5"));
        }

    }
}