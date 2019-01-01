using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using IOC_Autofac.Services.Interfaces;

namespace IOC_Autofac.Controllers
{
    public class HomeController : Controller
    {
        private ILog _log;
        private IEnumerable<ILog> _logList;

        public HomeController(ILog log, IEnumerable<ILog> logList) {
            _log = log;
            _logList = logList;
        }
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";
            ViewBag.LogTypeName = _log.GetType().Name;
            ViewBag.LogTypeNames = _logList.Select(x => x.GetType().Name).Aggregate((x, y) => x + "," + y);
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}