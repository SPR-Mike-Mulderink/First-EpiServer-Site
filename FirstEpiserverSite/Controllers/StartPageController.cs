﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstEpiserverSite.Models.Pages;
using EPiServer.Web.Mvc;

namespace FirstEpiserverSite.Controllers
{
    public class StartPageController : PageController<StartPage>
    {
        // GET: StartPage
        public ActionResult Index(StartPage currenyPage)
        {
            return View();
        }
    }
}