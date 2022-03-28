using Complains_System.Catalog.User;
using Complains_System.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Complains_System.Controllers
{

    public class UsersController : Controller
    {
        private readonly IUserService _userService;
        private readonly UserManager<AppUser> _usermanager;

        public UsersController(IUserService userService, UserManager<AppUser> usermanager)
        {
            _userService = userService;
            _usermanager = usermanager;

        }

        public ActionResult Logout()
        {
            _userService.Logout();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        [AllowAnonymous]
        public ViewResult Login()
        {
            
            ClaimsPrincipal currentUser = this.User;
            if (currentUser != null)
            {
                 _userService.Logout();
                return View();
            }
      
            return View();
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate(IFormCollection frm)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            LoginRequest request = new LoginRequest();
            request.Username = frm["username"].ToString();
            request.Password = frm["password"].ToString();
            request.RememberMe = false;
            var resultToken = await _userService.Login(request);
            if (resultToken == null)
            {
                TempData["Message"] = _userService.StatusMessage;
                return RedirectToAction("Login");
            }
            await HttpContext.SignInAsync(resultToken);
            
            var user =  _userService.getUser(request.Username);
            var id = user.IdStudent == null ? user.idteacher.ToString() : user.IdStudent;
            TempData["id"] = id;
            TempData["Name"] = user.Name;
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public ActionResult UserAccessDenied()
        {
            return View();
        }
    }
}
