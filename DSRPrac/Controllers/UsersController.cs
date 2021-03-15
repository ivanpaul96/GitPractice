using DSRPrac.Manager;
using DSRPrac.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DSRPrac.Controllers
{
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult User()
        {
            return View();
        }
        public JsonResult Add(Users users)
        {
            UsersManager usersManager = new UsersManager();
            var result=usersManager.Add(users);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        public void Test()
        {

        }
        public void Test1()
        {

        }
    }
}