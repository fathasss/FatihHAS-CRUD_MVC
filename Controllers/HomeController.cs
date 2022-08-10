using FatihHAS1.Attribute;
using FatihHAS1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FatihHAS1.Controllers
{   
    public class HomeController : Controller
    {       
        DataAccess.ProductAccess pro = new DataAccess.ProductAccess();

        [LoggerAttr]
        public ActionResult Index()
        {
            return View();
        }

        [LoggerAttr]
        public JsonResult List()
        {
            return Json(pro.ListAll(), JsonRequestBehavior.AllowGet);
        }

        [LoggerAttr]
        public JsonResult GetbyID(int ID)
        {
            var dataProduct = pro.ListAll().Find(x => x.ProductId.Equals(ID));
            return Json(dataProduct, JsonRequestBehavior.AllowGet);
        }


        [LoggerAttr]
        public JsonResult Add(Product prop)
        {
            return Json(pro.ProductAdd(prop), JsonRequestBehavior.AllowGet);
        }

        [LoggerAttr]
        public JsonResult Update(Product prop)
        {
            return Json(pro.ProductUpdate(prop), JsonRequestBehavior.AllowGet);
        }

        [LoggerAttr]
        public JsonResult Delete(Product prop)
        {
            return Json(pro.ProductDelete(prop), JsonRequestBehavior.AllowGet);
        }
    }
}