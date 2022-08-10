using FatihHAS1.Attribute;
using FatihHAS1.Models.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FatihHAS1.Controllers
{
    public class LoggerController : Controller
    {
        // GET: Logger
        public ActionResult Index()
        {
            return View();
        }

        [LoggerAttr]
        public JsonResult GetList()
        {
            return Json(LoggerAccess.GetList(), JsonRequestBehavior.AllowGet);
        }
    }
}