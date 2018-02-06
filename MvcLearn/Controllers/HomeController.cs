using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcLearn.Models;
namespace MvcLearn.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult UseExtension()
        {
            ShoppingCart shoppingCart = new ShoppingCart
            {
                Products = new List<Product> {
                new Product {Name = "Kayak", Price = 275M},
                    new Product {Name = "Lifejacket", Price = 48.95M},
                    new Product {Name = "Soccer ball", Price = 19.50M},
                    new Product {Name = "Corner flag", Price = 34.95M}}
            };
            //求购物车的价格总和
            decimal cartTotal = shoppingCart.GetTotalPrice();
            return View("Result",
                (object)String.Format("Total: {0:c}", cartTotal));
        }

        public ViewResult UseExtensionToint()
        {
            string soure = "100";
            int cartTotal = soure.ToInt(DateTime.Now);
            return View("Result",
                (object)String.Format("Total: {0:c}", cartTotal));
        }

    }
}