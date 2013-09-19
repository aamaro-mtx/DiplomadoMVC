using PaganaSoft.Northwind.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PaganaSoft.Mvc.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            var db = new NorthwindHelper();

            return View(db.GetCategories());
        }

    }
}
