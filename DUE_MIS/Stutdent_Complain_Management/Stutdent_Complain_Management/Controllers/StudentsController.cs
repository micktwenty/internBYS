using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stutdent_Complain_Management.Controllers
{
    public class StudentsController : Controller
    {
        // GET: Students
        public ActionResult Index()
        {
            int role = Convert.ToInt32(Session["Role"]);
            if (role % 2 == 0)
            {
                return View("Students");
            }
            else
            {
                ViewBag.Message = "Bạn không có quyền truy cập trang quản trị!";
                return View("Index");
            }
        }

    }
}