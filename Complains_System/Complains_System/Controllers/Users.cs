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
    [Route("[controller]")]
    //[ApiController]
    public class UsersController : Controller
    {
        private readonly IUserService _userService;
        private readonly UserManager<AppUser> _usermanager;

        public UsersController(IUserService userService, UserManager<AppUser> usermanager)
        {
            _userService = userService;
            _usermanager = usermanager;

        }
        [HttpGet("logout")]
        public ActionResult Logout()
        {
            _userService.Logout();
            TempData.Clear();
            return RedirectToAction("Index", "Home");
        }
        [HttpGet("Login")]
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
        //[HttpGet("change-password")]
        public ViewResult ChangePass()
        {
            return View();
        }
        [HttpPost("changepass")]
        public async Task<IActionResult> ChangePass_process(IFormCollection frm)
        {
            ClaimsPrincipal currentUser = this.User;
            if (currentUser == null) return RedirectToAction("Login");
            var Name = currentUser.FindFirst(ClaimTypes.Name).Value;
            var user = await _usermanager.FindByNameAsync(Name);
            var request = new ChangePasswordRequest()
            {
                OldPass = frm["oldpassword"],
                NewPass = frm["newpassword"],
                ConfirmNewPass = frm["comfirmpassword"],
                current_user = user 
            };
            var validator = new ChangePasswordValidator();
            var validateresult = await validator.ValidateAsync(request);
            if (validateresult.IsValid)
            {
                var result = await _userService.ChangePassword(request);
                if (result.Succeeded)
                {
                    return RedirectToAction("Login");
                }
            }
           
            return Content(string.Join(";",validateresult.Errors));
        }

        [HttpPost("authenticate")]
        [AllowAnonymous]
        public async Task<IActionResult> Authenticate([FromForm] IFormCollection frm)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            LoginRequest request = new LoginRequest();
            request.Username = frm["username"].ToString();
            request.Password = frm["password"].ToString();
            request.RememberMe =  false;
            if (Request.Form["remember"].Contains("true"))
            {
                request.RememberMe = true;
            }
            var validator = new LoginRequestValidator();
            var validateresult = await validator.ValidateAsync(request);
            if (validateresult.IsValid)
            {
                var result = await _userService.Login(request);
                if (result == null)
                {
                    TempData["Message"] = _userService.StatusMessage;
                    return RedirectToAction("Login");
                }
                await HttpContext.SignInAsync(result);
                var user =  _userService.getUser(request.Username);
                if (user.idteacher != 0)
                {
                    return RedirectToAction("GetRequestList", "Complains");
                }
                return RedirectToAction("Index", "Home");
            }

            return Content(string.Join(";", validateresult.Errors));
        }
        [HttpGet("access-deny")]
        public ActionResult UserAccessDenied()
        {
            return View();
        }
    }
}
