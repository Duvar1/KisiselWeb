using KisiselWeb.Models.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace KisiselWeb.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        Context c = new Context();
      
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Admin ad)
        {
            var info = c.Admins.FirstOrDefault(x => x.username == ad.username && x.password == ad.password);
            if (info != null)
{
                FormsAuthentication.SetAuthCookie(info.username, false);
                Session["username"] = info.username.ToString();
                return RedirectToAction("Index", "Admin");
            }
            else
            {
                return View();  
            }

        }
            public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
    }
}