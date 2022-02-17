using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stutdent_Complain_Management.Controllers
{
    public class AdminController : Controller
    {
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
    }
}