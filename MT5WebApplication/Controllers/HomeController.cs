﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MT5WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return Content("Home Page");
        }
    }
}
