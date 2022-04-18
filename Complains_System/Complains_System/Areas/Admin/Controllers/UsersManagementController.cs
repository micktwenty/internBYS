using Complains_System.Catalog.Admin.UserManagement;
using Complains_System.Catalog.Department;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Complains_System.Areas.Admin.Controllers
{
    [Route("[Area]")]
    [Area("Admin")]
    public class UsersManagementController : Controller
    {
        private readonly IUserManagementService _userManagementService;

        public UsersManagementController(IUserManagementService userManagementService)
        {
            _userManagementService = userManagementService;

        }
        [HttpGet("register")]
        public IActionResult Register()
        {
            return View("Register");
        }
        [HttpPost("register-by-excel")]
        public async Task<bool> RegisterbyExcel([FromForm]IFormFileCollection files)
        {


            IFormFile file = files[0];
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            var result = await _userManagementService.RegisterbyExcel(file);
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
