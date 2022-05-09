using Complains_System.Catalog.Admin.UserManagement;
using Complains_System.Catalog.Admin.UserManagement.Dtos;
using Complains_System.Catalog.Department;
using Complains_System.Catalog.User;
using Complains_System.Constants;
using Complains_System.EF;
using Complains_System.Models;
using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
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
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;
        private readonly IDepartmentService _departmentService;
        private readonly ComplainsDbContext _context;
        private readonly UserManager<AppUser> _userManager;



        public UsersManagementController(UserManager<AppUser> userManager, IUserManagementService userManagementService, IDepartmentService department, IUserService userService, IConfiguration configuration, ComplainsDbContext context)
        {
            _userManagementService = userManagementService;
            _departmentService = department;
            _userService = userService;
            _configuration = configuration;
            _context = context;
            _userManager = userManager;
        }
        [HttpGet("register")]
        public async Task<IActionResult> Register()
        {
            var data = await _departmentService.GetListDepartments();
            return View(data);
        }
        [HttpGet("permitting")]
        public async Task<IActionResult> Permiting(string id)
        
        {
            var user = await _userService.getUser(id);

            ViewBag.Role = _userManagementService.GetListRole();
            var result = new UserViewModel()
            {
                user = user,
                Role = await _userManagementService.GetListRole()
            };
            return View(result);
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
