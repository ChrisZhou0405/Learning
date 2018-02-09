using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Log4net_Demo.Common;
using MvcLearn;
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
            catch (Exception ex)
            {
                LogHelper.Error(LogAppender.RollingFileAppender, ex.ToString(), ex);
            }

            return View();
        }

        public ActionResult ToUpper(string str)
        {
            MvcLearn.Common.Utility.ToUpper(str);
            return View();
        }
    }
}