using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Stutdent_Complain_Management.Models;
using System.Security.Cryptography;
using System.Text;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;
using Dapper;

namespace Stutdent_Complain_Management.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        IDbConnection connn = new SqlConnection(ConfigurationManager.ConnectionStrings["ComplainsConn"].ConnectionString);

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Users user)
        {
            if (!ModelState.IsValidField("Username"))
            {
                return View();
            }
            else
            {
                var r_password = GetMD5(user.password);
                connn.Open();
                var login = connn.Query<Users>($"Select * from Accounts where username = '{user.username}' and password ='{r_password}'").FirstOrDefault();
                var infor = connn.Query<Students>($"Select * from Students where studentcode = '{user.username}'").FirstOrDefault();

                connn.Close();
                if (login != null)
                {
                    HttpCookie cookie = new HttpCookie("user", user.username.ToString());
                    cookie.Expires.AddHours(8);
                    HttpContext.Response.SetCookie(cookie);
                    ViewBag.Message = "Welcome";
                    Session["Username"] = login.username;
                    Session["Role"] = login.role;
                    Session["Actived"] = login.Actived;

                    if (Convert.ToBoolean(Session["Actived"]) == false)
                    {
                        return View("Info", infor);
                    }
                    else
                    {
                        return View("About");
                    }

                }
                else
                {
                    ViewBag.Message = "Wrong password or username";
                    return View();
                }

            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Info(Students stu)
        {
            connn.Open();
            connn.Execute($"Update Students set [name] = N'{stu.name}', phone = '{stu.phone}' where studentcode = '{Session["Username"]}'");
            connn.Execute($"Update Accounts set Actived = 1 where username = '{Session["Username"]}'");
            connn.Close();
            return RedirectToAction("Index","Home");
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