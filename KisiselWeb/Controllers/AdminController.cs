using KisiselWeb.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KisiselWeb.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();

        [Authorize]
        public ActionResult Index()
        {
            var value = c.HomePages.ToList();
            return View(value);
        }

        public ActionResult HomePageGet(int id)
        {
            var hpg = c.HomePages.Find(id);
            return View("HomePageGet", hpg);
        }
        public ActionResult HomePageUpdate(HomePage x)
        {
            var hpu = c.HomePages.Find(x.id);
            hpu.name = x.name;
            hpu.description = x.description;
            hpu.job = x.job;
            hpu.profile = x.profile;
            hpu.contact = x.contact;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult IconList()
        {
            var val = c.Icons.ToList();
            return View(val);
        }

        [HttpGet]
        public ActionResult NewIcon()
        {
            return View();
        }
 
        [HttpPost]
        public ActionResult NewIcon(Icon p)
        {
            c.Icons.Add(p);
            c.SaveChanges();
            return RedirectToAction("IconList");
        }

        public ActionResult IconGet(int id)
        {
            var ig =  c.Icons.Find(id);
            return View("IconGet", ig);
        }

        public ActionResult IconUpdate(Icon x)
        {
            var ig = c.Icons.Find(x.id);
            ig.icon = x.icon;
            ig.link = x.link;
            c.SaveChanges();
            return RedirectToAction("IconList");
        }

        public ActionResult IconRemove(int id)
        {
            var ır =c.Icons.Find(id);
            c.Icons.Remove(ır);
            c.SaveChanges();
            return RedirectToAction("IconList");
        }
    }
}