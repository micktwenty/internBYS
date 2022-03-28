using Complains_System.Catalog.Admin.UserManagement.Dtos;
using Complains_System.EF;
using Complains_System.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Catalog.Admin.UserManagement
{
    public class UserManagementService : IUserManagementService
    {
        private readonly UserManager<AppUser> _usermanager;
        private readonly ComplainsDbContext _context;


        public UserManagementService(UserManager<AppUser> userManager, ComplainsDbContext context)
        {
            _usermanager = userManager;
            _context = context;

        }
        public Task<bool> DeleteAccount(string username)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DisableAccount(string username)
        {
            throw new NotImplementedException();
        }

        public async Task<List<UserViewModel>> GetListUsers()
        {
            var data = from c in _context.AppUsers
                       select new { c};
           

            var listUser = await data.Select(x => new UserViewModel()
            {
                Name = x.c.Name,
                username = x.c.UserName
            }).ToListAsync();
            return listUser;
        }

        public async Task<bool> Register(RegisterRequest request)
        {



            if (request.Isemployee)
            {
                var user = new AppUser()
                {
                    Name = request.Name,
                    UserName = request.Email,
                    IdDepartment = request.IdDepartment,
                    Email = request.Email,
                    idteacher = await _context.Employees.MaxAsync(x => x.Id) + 1
                    
                };
                var result = await _usermanager.CreateAsync(user, request.Password);

                if (!result.Succeeded)
                {
                    return false;
                }
                result = await _usermanager.AddToRoleAsync(user, "employee");
                if (!result.Succeeded) return false;
                var employee = new Employee()
                {
                    Name = request.Name,
                    Email = request.Email,
                    DepartmentId = request.IdDepartment,
                    Id = await _context.Employees.MaxAsync(x => x.Id) + 1
                };
                _context.Employees.Add(employee);
                var result_reg = await _context.SaveChangesAsync();
                if (result_reg == 0)
                {
                    return false;
                }

            }
            else
            {
                var user = new AppUser()
                {
                    Name = request.Name,
                    UserName = request.IdStudent,
                    IdDepartment = request.IdDepartment,
                    Email = request.IdStudent + "@due.udn.vn",
                    IdStudent = request.IdStudent
                    
                };
                var result = await _usermanager.CreateAsync(user, request.Password);
                if (!result.Succeeded) return false;

                result = await _usermanager.AddToRoleAsync(user, "student");
                if (!result.Succeeded) return false;

                var student = new Student()
                {
                    Name = request.Name,
                    Sclass = request.sClass,
                    Studentcode = request.IdStudent,
                    DepartmentId = request.IdDepartment
                };
                _context.Students.Add(student);
                var result_reg = await _context.SaveChangesAsync();
                if (result_reg == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public Task<bool> ResetPassword(string username)
        {
            throw new NotImplementedException();
        }
    }
}
