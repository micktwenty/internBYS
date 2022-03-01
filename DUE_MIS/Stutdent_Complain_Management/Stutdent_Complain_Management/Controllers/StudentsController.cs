using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using Dapper;
using Stutdent_Complain_Management.Models;

namespace Stutdent_Complain_Management.Controllers
{
    public class StudentsController : Controller
    {
        IDbConnection connn = new SqlConnection(ConfigurationManager.ConnectionStrings["ComplainsConn"].ConnectionString);
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
                ViewBag.Message = "Bạn không có quyền truy cập trang sinh viên!";
                return View("Index");
            }
        }
        public ActionResult MyCln()
        {
            List<lstCln> cpl = new List<lstCln>();
            using (IDbConnection connn = new SqlConnection(ConfigurationManager.ConnectionStrings["ComplainsConn"].ConnectionString))
            {
                cpl = connn.Query<lstCln>($"Select Complains.IdComplains, Departments.name, Complains.title, Complains.status  from Complains inner join Departments on Complains.IdDepartment = Departments.Id where IdStudent = '{Session["Username"]}'").ToList();
            }
            return View(cpl);
        }
        public ActionResult Details_Complains(string id)
        {
           
            connn.Open();
            var model = connn.Query<Detail_Complains>($"Select Departments.name, Complains.title, Complains.contenttype, Complains.Content, complains.date, complains.picture, Complains.status , complains.reply  from Complains inner join Departments on Complains.IdDepartment = Departments.Id where IdComplains = {id}").FirstOrDefault();
            connn.Close();

            return View(model);
        }
    }
}