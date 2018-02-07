﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using System.Web.Mvc;

namespace WebApiHPUVEC.Controllers
{
    public class UIController : Controller
    {
        [ApiExplorerSettings(IgnoreApi = true)]
        public ActionResult Index()
        {
            ViewBag.Title = "UI Windows";

            return View();
        }

    }
}
