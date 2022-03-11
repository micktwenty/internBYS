using DUE_Complains.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace DUE_Complains.Controllers
{
    public class HomeController : Controller
    {

        private readonly string conn;
        
        public HomeController(IConfiguration configuration)
        {
            conn = configuration.GetConnectionString("ComplainsConn");
        }

        public IActionResult Index()
        {
            List<Employee> emp = new List<Employee>();
            using (var connection = new SqlConnection(conn))
            {
                 emp = connection.Query<Employee>("Select * from Employees").ToList();
            }
            return View(emp);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
