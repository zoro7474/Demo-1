using System.Linq;
using System.Web.Mvc;
using MvcRestaurant.Models.Entity;

namespace MvcRestaurant.Controllers
{
    public class HomeController : Controller
    {
        // GET: vitrin
        DBRESTAURANTEntities db = new DBRESTAURANTEntities();
        public ActionResult Index()
        {
            var degerler = db.TBLYEMEK.ToList();
            return View(degerler);
        }
    }
}