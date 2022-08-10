using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FatihHAS1.Attribute;
using FatihHAS1.Models;

namespace FatihHAS1.Controllers
{
    public class LoginController : Controller
    {
        DataAccess.LoginAccess db = new DataAccess.LoginAccess();
        // GET: Login

        [LoggerAttr]
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [LoggerAttr]
        public ActionResult Index(FormCollection formCollection)
        {
            int res = db.LoginAuth(formCollection["kname"], formCollection["pass"]);
            if (res == 1)
            {
                Session["LoginId"] = 1;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Kullanıcı adı veya şifre yanlış";
                return View();
            }
        }

        [LoggerAttr]
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}