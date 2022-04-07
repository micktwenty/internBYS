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

namespace Complains_System.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<AppUser> _usermanager;
        private readonly ComplainsDbContext _context;
        private readonly IComplainsManagement _complains;
        public HomeController(ILogger<HomeController> logger, UserManager<AppUser> usermanager, ComplainsDbContext context, IComplainsManagement complains)
        {
            _logger = logger;
            _usermanager = usermanager;
            _context = context;
            _complains = complains;
        }
        public async Task<IActionResult> Index(int? page)
        {
            ClaimsPrincipal currentUser = this.User;
            if (currentUser.FindFirst(ClaimTypes.Name) != null)
            {
                var Name = currentUser.FindFirst(ClaimTypes.Name).Value;
                var user = await _usermanager.FindByNameAsync(Name);
              
            }
           
            var lstComplains = await _complains.GetAll();
            var pageNumber = page ?? 1;
            pageNumber = pageNumber == 0 ? 1 : pageNumber;
            var pageSize = 6;
            return View(lstComplains.OrderByDescending(x => x.Date).ToPagedList(pageNumber,pageSize));
        }
        public async Task<IActionResult> Details(int id)
        {
            var detailsComplain = await _complains.GetbyId(id);
            return View(detailsComplain);
        }
        [Authorize(Roles ="employee")]
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
