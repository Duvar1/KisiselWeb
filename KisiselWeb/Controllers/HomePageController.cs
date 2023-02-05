using KisiselWeb.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisiselWeb.Controllers
{
    public class HomePageController : Controller
    {
        // GET: HomePage
        Context c = new Context();
        public ActionResult Index()
        {
            var value = c.HomePages.ToList();
            return View(value);
        }
        public PartialViewResult icons()
        {
            var value = c.Icons.ToList();
            return PartialView(value);
        }
    }
}