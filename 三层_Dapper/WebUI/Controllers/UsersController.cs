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
       
        // GET: Users
        public ActionResult Index()
        {
            int uid = 1;
            // Users users= new UsersBLL().GetUsers(uid);
            Users users = new UsersBLL().GetUsersByName("周城");
            //List<Users> users = new UsersBLL().GetAllUsers();
            return View(users);
        }

        public ActionResult Create() {
            var userBll = new UsersBLL();
            #region single Insert
            //Users users = new Users() { UserID = 10, UserName = "地狱火", Email = "10245781@163.com", Address = "皇后大道东" };
            //ViewBag.result = userBll.Insert(users);

            #endregion

            #region InsertBulk
            Users user = new Users() {UserName="球球",Email="10245781@163.com",Address="云南大理" };
            Users model = new Users() { UserName = "闰土", Email = "10245781@qq.com", Address = "云南丽江" };
            List<Users> users = new List<Users>();
            users.Add(user);
            users.Add(model);
            ViewBag.result = userBll.InsertBulk(users);
            return View(users);
            #endregion
        }

        public ActionResult Update()
        {
            var userBll = new UsersBLL();
           ViewBag.infoRe=userBll.UpdateInfo("广东梅州", "曾晓");
            Users users = new Users() { UserID=7, UserName="毛台", Address="湖北武汉",Email="154897415@163.com" };
            ViewData["updateRe"] = userBll.Update(users);
            return View();   
        }

        public ActionResult Delete()
        {
            var bll = new UsersBLL();
            ViewBag.singleRe = bll.SingleDelete(5);
            ViewBag.mulRe = bll.MulDelete(new int[] {6,7});
            return View();
        }

    }
}