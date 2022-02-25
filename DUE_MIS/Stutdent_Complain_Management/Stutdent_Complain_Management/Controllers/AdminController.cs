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

namespace Stutdent_Complain_Management.Controllers
{
    public class AdminController : Controller
    {
        Complains_DUEEntities db = new Complains_DUEEntities();


        
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

        [AllowAnonymous]
        public ActionResult StuReg()
        {   
            List<Department> Dep = db.Departments.ToList();
            SelectList lstDep = new SelectList(Dep, "Id", "name");
            ViewBag.Khoa = lstDep;
            return View("StuReg");
        }

        
       [HttpPost]
       [ValidateAntiForgeryToken]
        public ActionResult StuReg(RegisterViewModel_Stu user, System.Web.Mvc.FormCollection frm)
        {
            
            if (user.Password == user.ConfirmPassword)
            {
                Student stu = new Student();
                Account acc = new Account();
                var check = db.Accounts.Where(s => s.username.Equals(user.studentcode)).FirstOrDefault();
                if( check == null)
                {
                    
                        acc.password = GetMD5(user.Password);
                        db.Configuration.ValidateOnSaveEnabled = false;
                        stu.studentcode = user.studentcode;
                        acc.username = user.studentcode;
                        stu.@class = user.sClass;
                        stu.Department = user.Department;
                        acc.role = 2;
                        acc.Actived = false;
                        string dep = frm["Deps"];
                        stu.Department = Convert.ToInt32(dep);
                        db.Students.Add(stu);
                        db.Accounts.Add(acc);
                        db.SaveChanges();
                        ViewBag.Message = "Tạo mới tài khoản thành công.";
                        return RedirectToAction("Index", "Home");
                    
                    
                }
                else
                {
                    return RedirectToAction("StuReg", "Admin");

                }
            }
            return RedirectToAction("StuReg", "Admin");

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