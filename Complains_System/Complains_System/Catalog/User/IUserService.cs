
using Complains_System.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Complains_System.Catalog.User
{
     public interface IUserService
    {
        [TempData]
        public string StatusMessage { get; set; }
        Task<ClaimsPrincipal> Login(LoginRequest request);
        Task<IdentityResult> ChangePassword(ChangePasswordRequest request);

        public void Logout();
        public Task<AppUser> getUser(string username);

    }
}
