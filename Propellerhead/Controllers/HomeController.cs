﻿using System.Web.Mvc;

namespace Propellerhead.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return RedirectToAction("Index", "Customers");
        }
        
    }
}