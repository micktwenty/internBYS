using Complains_System.Catalog.Admin.UserManagement;
using Complains_System.Catalog.Department;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[Area]")]
    public class UsersManagementController : Controller
    {
        private readonly IUserManagementService _userManagementService;
        private readonly IDepartmentService _departmentService;


        public UsersManagementController(IUserManagementService userManagementService, IDepartmentService department)
        {
            _userManagementService = userManagementService;
            _departmentService = department;

        }
        [HttpGet("register")]
        public async Task<IActionResult> Register()
        {
            var data = await _departmentService.GetListDepartments();
            return View(data);
        }
        [HttpGet("user-manager")]
        public async Task<IActionResult> usermanager()
        {
            var data = await _userManagementService.GetListUsers();
            return View(data);
        }
        [HttpPost("Register-by-Excel-stu")]
        public async Task<bool> RegisterbyExcelforStu([FromForm]IFormFileCollection files)
        {
            IFormFile file = files[0];
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var result = await _userManagementService.RegisterbyExcelStu(file);
                return result;
        }
        [HttpPost("register-by-normal-stu")]
        public async Task<bool> RegisterforStu([FromForm]IFormCollection frm)
        {
            var request = new RegisterRequest()
            {
                IdStudent = frm["idstu"],
                Name = frm["stu_name"],
                IdDepartment = Convert.ToInt32(frm["khoa"]),
                sClass = frm["class"],
                Isemployee = false,
                Password = "Mis@2022",
                ConfirmPassword = "Mis@2022"
            };
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var result = await _userManagementService.Register(request);
            return result;
        }
        [HttpPost("Register-by-Excel-emp")]
        public async Task<bool> RegisterbyExcelforEmployee([FromForm] IFormFileCollection emp_files)
        {
            IFormFile file = emp_files[0];
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var result = await _userManagementService.RegisterbyExcelEmp(file);
            return result;
        }
        [HttpPost("register-by-normal-emp")]
        public async Task<bool> RegisterforEmployee([FromForm] IFormCollection frm)
        {
            var request = new RegisterRequest()
            {
                Email = frm["email"],
                Name = frm["emp_name"],
                IdDepartment = Convert.ToInt32(frm["khoa"]),
                Isemployee = true,
                Password = "Mis@2022",
                ConfirmPassword = "Mis@2022"
            };
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var result = await _userManagementService.Register(request);
            return result;
        }
        [HttpGet("disable-acc")]
        public async Task<bool> disable(string username)
        {
            var result = await _userManagementService.DisableAccount(username);
            return result;
        }
        [HttpGet("enable-acc")]
        public async Task<bool> enable(string username)
        {
            var result = await _userManagementService.EnableAccount(username);
            return result;
        }
        [HttpGet("delete-acc")]
        public async Task<bool> delete(string username)
        {
            var result = await _userManagementService.DeleteAccount(username);
            return result;
        }
    }
}
