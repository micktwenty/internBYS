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

        
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        

        
    }
}