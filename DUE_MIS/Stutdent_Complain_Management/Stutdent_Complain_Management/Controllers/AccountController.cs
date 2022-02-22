using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stutdent_Complain_Management.Models;
using System.Security.Cryptography;
using System.Text;


namespace Stutdent_Complain_Management.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        Complains_DUEEntities db = new Complains_DUEEntities();
      
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
                var r_password = GetMD5(user.password);
                var login = db.Accounts.Where(p => p.username.Equals(user.username) && p.password.Equals(r_password)).FirstOrDefault();
                if (login != null)
                {
                    HttpCookie cookie = new HttpCookie("user", user.username.ToString());
                    cookie.Expires.AddHours(8);
                    HttpContext.Response.SetCookie(cookie);
                    ViewBag.Message = "Welcome";
                    Session["Username"] = login.username;
                    Session["Role"] = login.role;

                    return View("About");
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
        public static string GetMD5(string str)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] fromData = Encoding.UTF8.GetBytes(str);
            byte[] targetData = md5.ComputeHash(fromData);
            string byte2String = null;

            for (int i = 0; i < targetData.Length; i++)
            {
                byte2String += targetData[i].ToString("x2");

            }
            return byte2String;
        }
    }
}