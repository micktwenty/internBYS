using Complains_System.Catalog.Admin.ComplainsManagement;
using Complains_System.Catalog.Admin.UserManagement;
using Complains_System.Catalog.Department;
using Complains_System.EF;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Areas.Admin.Controllers
{
    //[Authorize(Roles ="admin")]\
    //[Route("[controller]")]
    //[Area("Admin")]
    [Area("Admin")]
    [Authorize(Roles ="admin")]
    public class HomePageController : Controller
    {
        private readonly IUserManagementService _userManagementService;
        private readonly IDepartmentService _departmentService;
        private readonly IComplainsService _complain;


        public HomePageController(IUserManagementService userManagementService, IComplainsService complain, IDepartmentService departmentService)
        {
            _userManagementService = userManagementService;
            _complain = complain;
            _departmentService = departmentService;
        }

        public async Task<IActionResult> Index(int? page)
        {
            ViewData["Title"] = "Quản trị viên";
            var listKhoa = await _departmentService.GetListDepartments();
            
            var report_all = _complain.Statistics_Report(page);
            report_all.Departments = listKhoa;
            return View(report_all);
        }


        public async Task<IActionResult> ReportforDepartment([FromForm] IFormCollection frm, int? page)
        {
            if (ModelState.IsValid)
            {
                var listKhoa = await _departmentService.GetListDepartments();
                try
                {
                    var request = new StatisticalRequest()
                    {
                        startdate = Convert.ToDateTime(frm["startdate"]),
                        enddate = Convert.ToDateTime(frm["enddate"])
                    };
                    var report =  _complain.Statistics_Report_Department(request,page);
                    report.Departments = listKhoa;
                    report.startdate = Convert.ToDateTime(frm["startdate"]);
                    report.enddate = Convert.ToDateTime(frm["enddate"]);
                    return View(report);
                }
                catch (FormatException)
                {

                    return RedirectToAction("Index","Homepage");
                }
            }
           
            return View("Index");
        }
           


    }
}
