using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models;
using BLL;
using System.Configuration;

namespace WebUI.Controllers
{
    public class UsersController : Controller
    {
       // private readonly string connectionStr = ConfigurationManager.ConnectionStrings["Learn"].ConnectionString;
        private readonly string connectionStr2 = ConfigurationManager.AppSettings["Learn"];

        // GET: Users
        public ActionResult Index()
        {
            int uid = 1;
            Users users= new UsersBLL().GetUsers(uid);
            return View(users);
        }
    }
}