
using DUE_Complains.Models;
using DUE_Complains.System.Exceptions;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DUE_Complains.System.User
{
    public class UserService : IUserService
    {
        private readonly UserManager<AppUser> _usermanager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        private readonly IConfiguration _config;


        public UserService(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, RoleManager<AppRole> roleManager, IConfiguration config)
        {
            _usermanager = userManager;
            _signInManager = signInManager;
            _roleManager = roleManager;
            _config = config;
        }
        public async Task<string> Authenticate(LoginRequest request)
        {
            //xác thực
            var user = await _usermanager.FindByNameAsync(request.Username);
            if (user == null) return null;
            var result = await _signInManager.PasswordSignInAsync(user,request.Password,request.RememberMe,false);
            if (!result.Succeeded) return null;
            var role = await _usermanager.GetRolesAsync(user);
            var claims = new[]
            {
                new Claim(ClaimTypes.Name,user.Name),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Role , string.Join(";",role))
            };
            //mã hóa claim
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Tokens:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Tokens:Issuer"],
                _config["Tokens:Issuer"],
                claims,
                expires: DateTime.Now.AddHours(3),
                signingCredentials: creds);
            return  new JwtSecurityTokenHandler().WriteToken(token) ;
        }

        public async Task<bool> Register_stu(RegisterRequest request)
        {
            var user = new AppUser()
            {

                UserName = request.UserName,
                IdDepartment = request.IdDepartment,
                IdStudent = request.IdStudent != null ? request.IdStudent : null,
                idteacher = request.IdTeacher != null ? request.IdTeacher : null,
                Email = request.Email != null ? request.Email : null
            };
            var result = await _usermanager.CreateAsync(user, request.Password);
            if (result.Succeeded)
            {
                return true;
            }
            return false;
        }
    }
}
