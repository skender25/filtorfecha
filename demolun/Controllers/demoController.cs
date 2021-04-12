using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace demolun.Controllers
{
    public class demoController : Controller
    {
        // GET: demo
        BIBLIOTECAEntities db = new BIBLIOTECAEntities();
        public ActionResult Index()
        {

            return View(db.LIBRO.ToList()); 
        }

        [HttpPost]
        public ActionResult Index(DateTime start,DateTime end)
        {

            return View(db.GetFuntion(start,end));
        }
    }
}