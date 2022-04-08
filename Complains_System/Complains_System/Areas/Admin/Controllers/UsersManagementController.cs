using Complains_System.Catalog.Admin.UserManagement;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Areas.Admin.Controllers
{
    [Route("[controller]")]
    public class UsersManagementController : Controller
    {
        private readonly IUserManagementService _userManagementService;
        public UsersManagementController(IUserManagementService userManagementService)
        {
            _userManagementService = userManagementService;
        }
        [HttpPost("register")]
        public async Task<bool> Register([FromForm] RegisterRequest request)
        {
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
