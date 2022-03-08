using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using Stutdent_Complain_Management.Models;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;

namespace Stutdent_Complain_Management.Controllers
{
    public class AdminController : Controller
    {
        IDbConnection connn = new SqlConnection(ConfigurationManager.ConnectionStrings["ComplainsConn"].ConnectionString);


        // GET: Admin
        public ActionResult admin()
        {
            int role = Convert.ToInt32(Session["Role"]);
            if (role % 6 != 0)
            {
                ViewBag.Message = "Bạn không có quyền truy cập trang quản trị!";
                return View("Index");
            }
            return View("adminview");
        }


        public ActionResult StuReg()
        {
            connn.Open();
            List<Departments> Dep = connn.Query<Departments>("Select * from Departments").ToList();
            connn.Close();
            SelectList lstDep = new SelectList(Dep, "Id", "name");
            ViewBag.Khoa = lstDep;
            return View("StuReg");
        }

        
       [HttpPost]
       [ValidateAntiForgeryToken]
        public ActionResult StuReg(RegisterViewModel_Stu user, System.Web.Mvc.FormCollection frm)
        {
            user.Department = Convert.ToInt32(frm["Deps"]);
            if (user.Password == user.ConfirmPassword)
            {
                connn.Open();
                var check = connn.Query<Users>($"Select username from accounts where username = '{user.studentcode}'").FirstOrDefault();
                if (check == null)
                {

                    var p = new DynamicParameters();
                    p.Add("@username", user.studentcode);
                    p.Add("@class", user.sclass);
                    p.Add("@deps", frm["Deps"]);
                    p.Add("@pass", GetMD5(user.Password));
                    try
                    {
                        connn.Execute("newStudent", p, commandType: CommandType.StoredProcedure);
                    }
                    catch (Exception ex)
                    {

                        Console.WriteLine(ex);
                    }

                    ViewBag.Message = "Tạo mới tài khoản thành công.";
                    connn.Close();
                    return RedirectToAction("Index", "Home");
                    
                    
                }
                else
                {
                    connn.Close();
                    ViewBag.Message = "Tài khoản đã tồn tại";
                    return View("StuReg",user);

                }
            }
            ViewBag.Message = "Mật khẩu không trùng khớp";
            return View("StuReg", user);

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