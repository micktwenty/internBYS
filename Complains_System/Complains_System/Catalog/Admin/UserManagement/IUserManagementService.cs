using Complains_System.Catalog.Admin.UserManagement.Dtos;
using Complains_System.Catalog.User;
using Complains_System.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Catalog.Admin.UserManagement
{
    public interface IUserManagementService
    {
        public Task<List<UserViewModel>> GetListUsers();
        public Task<bool> ResetPassword(string username);
        public Task<bool> DisableAccount(string username);
        public Task<bool> EnableAccount(string username);
        public Task<bool> RegisterbyExcel(IFormFile file);
        public Task<bool> DeleteAccount(string username);
        public Task<bool> Register(RegisterRequest request);
    }
}
