using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcRestaurant.Models.Entity;
using System.Web.Security;

namespace MvcRestaurant.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        DBRESTAURANTEntities db = new DBRESTAURANTEntities();
        public ActionResult GirisYap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GirisYap(TBLUYELER p)
        {
            var bilgiler = db.TBLUYELER.FirstOrDefault(x => x.MAIL == p.MAIL && x.SIFRE == p.SIFRE && x.YETKİ==2);
            var admin = db.TBLUYELER.FirstOrDefault(x => x.MAIL == p.MAIL && x.SIFRE == p.SIFRE && x.YETKİ == 1);
            var sef = db.TBLUYELER.FirstOrDefault(x => x.MAIL == p.MAIL && x.SIFRE == p.SIFRE && x.YETKİ == 3);
            var garson = db.TBLUYELER.FirstOrDefault(x => x.MAIL == p.MAIL && x.SIFRE == p.SIFRE && x.YETKİ == 4);
            //şartlı döngüler
            if (bilgiler!=null)
            {
                FormsAuthentication.SetAuthCookie(bilgiler.MAIL, false);
                Session["Mail"] = bilgiler.MAIL.ToString();
                return RedirectToAction("Index", "Panelim");
            }
            else if (admin != null)
            {
                FormsAuthentication.SetAuthCookie(admin.MAIL, false);
                Session["Mail"] = admin.MAIL.ToString();
                return RedirectToAction("Index", "Kategori");
            }
            else if (sef != null)
            {
                FormsAuthentication.SetAuthCookie(sef.MAIL, false);
                Session["Mail"] = sef.MAIL.ToString();
                return RedirectToAction("Index", "Sefmenu");
            }
            else if (garson != null)
            {
                FormsAuthentication.SetAuthCookie(garson.MAIL, false);
                Session["Mail"] = garson.MAIL.ToString();
                return RedirectToAction("Index", "garsonpanel");
            }
            else
            {
                return View();
            }
        }

    }
}