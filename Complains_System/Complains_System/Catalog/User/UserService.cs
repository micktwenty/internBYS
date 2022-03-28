using System.Linq;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Complains_System.EF;
using Complains_System.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace Complains_System.Catalog.User
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _usermanager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly ComplainsDbContext _context;


        [TempData]
        public string StatusMessage { get; set; }
        public UserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,  ComplainsDbContext context)
        {
            _usermanager = userManager;
            _signInManager = signInManager;
            _context = context;

        }

        public async void Logout()
        {

           await _signInManager.SignOutAsync();
           
        }
        public async Task<ClaimsPrincipal> Login(LoginRequest request)
        {

            var user = await _context.AppUsers.FindAsync(request.Username);
            if (user != null)
            {
                if (user.IsActive == false)
                {
                    StatusMessage = "Error: Tài khoản của bạn tạm thời bị khoá, vui lòng liên hệ phòng tiếp nhận phản ánh sinh viên để được hỗ trợ!";
                    return null;
                }
                StatusMessage = null;
                var result = await _signInManager.PasswordSignInAsync(user, request.Password, request.RememberMe, false);
                if (!result.Succeeded) 
                {
                    StatusMessage = "Error: Mật khẩu không đúng!";
                    return null; 
                }
                
                var role = await _usermanager.GetRolesAsync(user);
                
                var userClaims = new List<Claim>()
                {
                    new Claim("UserName", user.UserName),
                    new Claim(ClaimTypes.Name, user.Name),
                    new Claim(ClaimTypes.Role, string.Join(";", role)),
                    new Claim("id", user.IdStudent == null ? user.idteacher.ToString() : user.IdStudent)
                };
                
                var userIdentity = new ClaimsIdentity(userClaims, "User Identity");

                var userPrincipal = new ClaimsPrincipal(new[] { userIdentity});
                
                return userPrincipal;
            }

            StatusMessage = "Error: Tài khoản không tồn tại!";
            return null;
        }
       

       
        public AppUser getUser(string username)
        {
            return _context.AppUsers.Find(username);
        }

        public string Message(string content)
        {
            var message = content;
            return message;
        }
    }
}
