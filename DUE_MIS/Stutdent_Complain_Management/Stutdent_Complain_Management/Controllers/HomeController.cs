using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using System.Data.SqlClient;
using System.Data;
using Stutdent_Complain_Management.Models;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Text;

namespace Stutdent_Complain_Management.Controllers
{
    public class HomeController : Controller
    {
        AccountEntities db = new AccountEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(User user)
        {
            if (!ModelState.IsValidField("Username"))
            {
                return View();
            }
            else
            {

                var login = db.Users.Where(p => p.Username.Equals(user.Username) && p.Password.Equals(user.Password)).FirstOrDefault();
                if (login != null)
                {
                    HttpCookie cookie = new HttpCookie("user", user.Username.ToString());
                    cookie.Expires.AddHours(8);
                    HttpContext.Response.SetCookie(cookie);
                    ViewBag.Message = "Welcome";
                    Session["Username"] = login.Username;
                    Session["Id"] = login.Id;

                    return RedirectToAction("About");
                }
                else
                {
                    ViewBag.Message = "Wrong password or username";
                    return View();
                }

            }

        }
        public ActionResult Logout()
        {
            Session.Clear();//remove session
            return RedirectToAction("Login");
        }

    }
}