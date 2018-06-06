﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Log4net_Demo.Common;

namespace Log4net_Demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(int id)
        {
            try
            {
                int result = 8/id;
            }
            catch (Exception e)
            {
                LogHelper.Error(LogAppender.FileAppender, e.ToString(), e);
                throw;
            }

            return View();
        }
    }
}