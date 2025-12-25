using System.Linq;
using System.Web.Mvc;
using Medinova.Models;

public class AdminAboutController : Controller
{
    MedinovaContext db = new MedinovaContext(); 

    // GET: AdminAbout
    public ActionResult Index()
    {
        var values = db.Abouts.ToList();
        return View(values);
    }
}
