using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcRestaurant.Models.Entity;

namespace MvcRestaurant.Controllers
{
    public class SiparisController : Controller
    {
        // GET: Siparis
        DBRESTAURANTEntities db = new DBRESTAURANTEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLHAREKET.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult Siparisver()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Siparisver(TBLHAREKET p)
        {
            db.TBLHAREKET.Add(p);
            db.SaveChanges();
            return View();
        }
        public ActionResult Siparisiptal(int id)
        {
            var yemek = db.TBLHAREKET.Find(id);
            db.TBLHAREKET.Remove(yemek);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}