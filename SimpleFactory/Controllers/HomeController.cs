using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimpleFactory.Interfaces;

namespace SimpleFactory.Controllers
{
    public class HomeController : Controller
    {
        private Factory _factory = new Factory();
        public ActionResult Index()
        {
            ICar hongqi = _factory.CreateCar("hongqi");
            ViewBag.Message = hongqi.ShowInfo();
            ICar maserati = _factory.CreateCar("maserati");
            ViewBag.mace = maserati.ShowInfo();
            return View();
        }

        public ActionResult Hongqi()
        {
          
            

            return View();
        }

        public ActionResult Maserati()
        {

            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}