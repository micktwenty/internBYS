using Complains_System.Catalog.Admin.UserManagement;
using Complains_System.Catalog.Admin.UserManagement.Dtos;
using Complains_System.Catalog.Department;
using Complains_System.Catalog.User;
using Complains_System.Constants;
using Complains_System.EF;
using Complains_System.Models;
using Dapper;
using Microsoft.AspNetCore.Authorization;
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
using X.PagedList;


namespace Complains_System.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("[Area]")]
    [Authorize(Roles = "admin")]
    public class UsersManagementController : Controller
    {
        private readonly IUserManagementService _userManagementService;
        private readonly IUserService _userService;
        private readonly IConfiguration _configuration;
        private readonly IDepartmentService _departmentService;
        private readonly ComplainsDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signinManager;




        public UsersManagementController(SignInManager<AppUser> signinManager, UserManager<AppUser> userManager, IUserManagementService userManagementService, IDepartmentService department, IUserService userService, IConfiguration configuration, ComplainsDbContext context)
        {
            _userManagementService = userManagementService;
            _departmentService = department;
            _userService = userService;
            _configuration = configuration;
            _context = context;
            _userManager = userManager;
            _signinManager = signinManager;
        }
        [HttpGet("reset-password")]
        public async Task<IActionResult> ResetPassword(string id)
        {
            var data = await _userManagementService.ResetPassword(id);
            string message;
            if (data)
            {
                message = "Thành công!";
            }
            else
            {
                message = "Không thành công!";
            }
            TempData["Noti"] = message;
            return RedirectToAction("usermanager");
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

        [HttpPost("permitting-process")]
        public async Task<IActionResult> PermitingInProcess(IFormCollection frm)

        {
            var rolelist = await _userManagementService.GetListRole();
            var user = _userService.getUser(frm["username"]).Result;
            bool result = true;
            foreach (var item in rolelist)
            {
                var role = frm[$"{item.id}"];
                if (role == ($"{item.id}"))
                {
                   var check = await _userManagementService.IsInRole(user,item.id);
                    if (!check)
                    {
                         result = await _userManagementService.AddRole(user.Id, item.id,user.UserName);
                    }
                    
                }
                else
                {
                    var check = await _userManagementService.IsInRole(user, item.id);
                    if (check)
                    {
                         result = await _userManagementService.RemoveRole(user.Id, item.id);
                    }
                }
            }
            string message;
            if (result)
            {
                message = "Thành công!";
            }
            else
            {
                message = "Không thành công";
            }
            TempData["Noti"] = message;
            return RedirectToAction("usermanager");

        
        }
        [HttpGet("user-manager")]

        public async Task<IActionResult> usermanager(int? page)
        {

            var pageNumber = page ?? 1;
            pageNumber = pageNumber == 0 ? 1 : pageNumber;
            var pageSize = 15;
            var data = await _userManagementService.GetListUsers();
            return View(data.OrderBy(x => x.username).ToPagedList(pageNumber, pageSize));
        }
        [HttpPost("user-manager/find")]
        public async Task<IActionResult> finduser( IFormCollection? frm)
        {
            var data = await _userManagementService.FindbyKeyword(frm["keyword"]);
            return View(data.OrderBy(x => x.username).ToList());
        }
        [HttpPost("Register-by-Excel-stu")]
        public async Task<IActionResult> RegisterbyExcelforStu([FromForm]IFormFileCollection files)
        {
            IFormFile file = files[0];
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var result = await _userManagementService.RegisterbyExcelStu(file);
            string message;
            if (result)
            {
                message = "Tạo mới thành công!";
            }
            else
            {
                message = "Tạo mới không thành công";
            }
            TempData["Noti"] = message;
            return RedirectToAction("Register");
        }
        [HttpPost("register-by-normal-stu")]
        public async Task<IActionResult> RegisterforStu([FromForm]IFormCollection frm)
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
            string message;
            if (result)
            {
                message = "Tạo mới thành công!";
            }
            else
            {
                message = "Tạo mới không thành công";
            }
            TempData["Noti"] = message;
            return RedirectToAction("Register");
        }
        [HttpPost("register-director")]
        public async Task<IActionResult> RegisterforDirector([FromForm] IFormCollection frm)
        {
            var request = new RegisterRequest()
            {
                Email = frm["email"],
                Name = frm["name"],
                phone =frm["phone"],
                Isemployee = null,
                Password = "Due@2022",
                ConfirmPassword = "Due@2022"
            };
            var result = await _userManagementService.Register(request);
            string message;
            if (result)
            {
                message = "Tạo mới thành công!";
            }
            else
            {
                message = "Tạo mới không thành công";
            }
            TempData["Noti"] = message;
            return RedirectToAction("Register");
        }
        [HttpPost("Register-by-Excel-emp")]
        public async Task<IActionResult> RegisterbyExcelforEmployee([FromForm] IFormFileCollection emp_files)
        {
            IFormFile file = emp_files[0];
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var result = await _userManagementService.RegisterbyExcelEmp(file);
            string message;
            if (result)
            {
                message = "Tạo mới thành công!";
            }
            else
            {
                message = "Tạo mới không thành công";
            }
            TempData["Noti"] = message;
            return RedirectToAction("Register");
        }
        [HttpPost("register-by-normal-emp")]
        public async Task<IActionResult> RegisterforEmployee([FromForm] IFormCollection frm)
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
            string message;
            if (result)
            {
                message = "Tạo mới thành công!";
            }
            else
            {
                message = "Tạo mới không thành công";
            }
            TempData["Noti"] = message;
            return RedirectToAction("Register");
        }
        [HttpGet("disable-acc")]
        public async Task<IActionResult> disable(string id)
        {
            var result = await _userManagementService.DisableAccount(id);
            if (result)
            {
                return RedirectToAction("usermanager");
            }
            return BadRequest(result);
        }
        [HttpGet("enable-acc")]
        public async Task<IActionResult> enable(string id)
        {
            var result = await _userManagementService.EnableAccount(id);
            if (result)
            {
                return RedirectToAction("usermanager");
            }
            return BadRequest(result);
        }
        [HttpGet("delete-acc")]
        public async Task<IActionResult> delete(string id)
        {
            var result = await _userManagementService.DeleteAccount(id);
            if (result)
            {
                return RedirectToAction("usermanager");
            }
            return BadRequest();
        }
    }
}
