using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FatihHAS1.Attribute;
using FatihHAS1.Models;

namespace FatihHAS1.Controllers
{
    public class SearchController : Controller
    {
        [LoggerAttr]
        public JsonResult List(string T9Text)
        {
            return Json(DataAccess.SearchAccess.Search(T9Text),JsonRequestBehavior.AllowGet);
        }
    }
}