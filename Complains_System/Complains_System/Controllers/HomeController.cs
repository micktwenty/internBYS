using Complains_System.Catalog;
using Complains_System.EF;
using Complains_System.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using X.PagedList.Mvc.Core;
using X.PagedList;
using System;
using Complains_System.Catalog.Complains.Dtos;
using System.Collections.Generic;
using Complains_System.Catalog.User;

namespace Complains_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> _usermanager;
        private readonly ComplainsDbContext _context;
        private readonly IComplainsManagement _complains;
        private readonly IUserService _userService;
        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> usermanager, ComplainsDbContext context, IComplainsManagement complains, IUserService userService)
        {
            _logger = logger;
            _usermanager = usermanager;
            _context = context;
            _complains = complains;
            _userService = userService;
        }
        public async Task<IActionResult> Index(int? page)
        {
            //var usname = _usermanager.GetUserName(this.User);
            //var user = _userService.getUser(usname);
            //if (user != null)
            //{
            //    var roles = await _usermanager.GetRolesAsync(user);
            //    if (roles.Contains("employee"))
            //    {
            //        return RedirectToAction("GetRequestList", "Complains");
            //    }
            //    else if (roles.Contains("admin"))
            //    {
            //        return Redirect("/admin");
            //    }
            //}

            var lstComplains = await _complains.GetAll();
            var pageNumber = page ?? 1;
            pageNumber = pageNumber == 0 ? 1 : pageNumber;
            var pageSize = 6;
            return View(lstComplains.OrderByDescending(x => x.Date).ToPagedList(pageNumber,pageSize));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
