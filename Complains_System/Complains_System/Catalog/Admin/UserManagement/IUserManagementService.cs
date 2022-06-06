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
        public Task<List<Role>> GetListRole();
        public Task<bool> IsInRole(AppUser user, string id);
        public Task<bool> AddRole(string id_user, string id_role, string username);
        public Task<bool> RemoveRole(string id_user, string id_role);


        public Task<List<UserViewModel>> FindbyKeyword(string username);
        public Task<bool> ResetPassword(string username);
        public Task<bool> DisableAccount(string username);
        public Task<bool> EnableAccount(string username);
        public Task<bool> RegisterbyExcelStu(IFormFile file);
        public Task<bool> RegisterbyExcelEmp(IFormFile file);

        public Task<bool> DeleteAccount(string username);
        public Task<bool> Register(RegisterRequest request);
    }
}
