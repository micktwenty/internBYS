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

namespace Stutdent_Complain_Management.Controllers
{
    public class AdminController : Controller
    {
        Complains_DUEEntities db = new Complains_DUEEntities();

        // GET: Admin
        public ActionResult admin()
        {
            int role = Convert.ToInt32(Session["Role"]);
            if (role % 6 == 0)
            {
                return View("adminview");
            }
            else
            {
                ViewBag.Message = "Bạn không có quyền truy cập trang quản trị!";
                return View("Index");
            }
        }

        [AllowAnonymous]
        public ActionResult StuReg()
        {
            List<Department> Dep = db.Departments.ToList();
            SelectList lstDep = new SelectList(Dep, "id", "name");
            ViewBag.Khoa = lstDep;
            return View("StuReg");
        }
       
        

    }
}