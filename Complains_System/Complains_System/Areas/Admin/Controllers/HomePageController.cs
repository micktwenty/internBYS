using Complains_System.Catalog.Admin.UserManagement;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Areas.Admin.Controllers
{
    public class HomePageController : Controller
    {
        private readonly IUserManagementService _userManagementService;
        public HomePageController(IUserManagementService userManagementService)
        {
            _userManagementService = userManagementService;
        }
        public async Task<IActionResult> Index()
        {
            var lst = await _userManagementService.GetListUsers();
            return View(lst);
        }
    }
}
