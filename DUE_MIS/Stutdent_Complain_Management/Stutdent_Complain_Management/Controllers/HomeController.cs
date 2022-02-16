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
        Complains_DUEEntities db = new Complains_DUEEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult admin()
        {
            int role = Convert.ToInt32(Session["Role"]);
            if (role % 6 == 0)
            {
                return View("AdminView");
            }
            else
            {
                ViewBag.Message = "Bạn không có quyền truy cập trang quản trị!";
                return View("Index");
            }
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
        public ActionResult Login(Account user)
        {
            if (!ModelState.IsValidField("Username"))
            {
                return View();
            }
            else
            {

                var login = db.Accounts.Where(p => p.username.Equals(user.username) && p.password.Equals(user.password)).FirstOrDefault();
                if (login != null)
                {
                    HttpCookie cookie = new HttpCookie("user", user.username.ToString());
                    cookie.Expires.AddHours(8);
                    HttpContext.Response.SetCookie(cookie);
                    ViewBag.Message = "Welcome";
                    Session["Username"] = login.username;
                    Session["Role"] = login.role;

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