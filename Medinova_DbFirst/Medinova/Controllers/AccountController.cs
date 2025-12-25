using Medinova.DTOs;
using Medinova.Models;
using System.Linq;
using System.Web.Mvc;
using System.Web.Security;

namespace Medinova.Controllers
{
    [AllowAnonymous]
    public class AccountController : Controller
    {
        MedinovaContext context = new MedinovaContext();
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginDto model)
        {
            var user = context.Users.FirstOrDefault(x=>x.UserName == model.UserName && x.Password == model.Password);
            if (user == null)
            {
                ModelState.AddModelError("","Kullanıcı adı veya şifre hatalı");
                return View(model);
            }

            FormsAuthentication.SetAuthCookie(user.UserName,false);
            Session["userName"] = user.UserName;
            Session["fullName"] = user.FirstName + " " + user.LastName;

            return RedirectToAction("Index","AdminDoctor");
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("Login");
        }
    }
}
