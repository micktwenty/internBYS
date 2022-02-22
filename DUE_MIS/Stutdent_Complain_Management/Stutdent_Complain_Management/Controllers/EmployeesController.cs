using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Stutdent_Complain_Management.Controllers
{
    public class EmployeesController : Controller
    {
        // GET: Employees
        public ActionResult Index()
        {
            int role = Convert.ToInt32(Session["Role"]);
            if (role % 3  == 0)
            {
                return View("employeesview");
            }
            else
            {
                ViewBag.Message = "Bạn không có quyền truy cập trang giảng viên!";
                return View("Index");
            }
        }
    }
}