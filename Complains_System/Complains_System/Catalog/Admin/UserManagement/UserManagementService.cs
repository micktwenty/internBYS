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
        public async Task<bool> DeleteAccount(string username)
        {
            
            var user = await _usermanager.FindByNameAsync(username);
            var student = await _context.Students.FindAsync(username);
            var employee = await _context.Employees.FirstOrDefaultAsync(x => x.Id == user.idteacher);
            var result = 1;

            if (student != null)
            {
                var complains = await _context.Complains.Where(x => x.IdStudent == student.Studentcode).ToListAsync();
                _context.Complains.RemoveRange(complains);
                _context.Students.Remove(student);
                result = await _context.SaveChangesAsync();

            }
            if (employee != null)
            {
                var complains = await _context.Complains.Where(x => x.employee_reply == employee.Id).ToListAsync();
                _context.Complains.RemoveRange(complains);
                _context.Employees.Remove(employee);
                result = await _context.SaveChangesAsync();

            }
            await _usermanager.DeleteAsync(user);
            if (result == 0)
            {
                return false;
            }
            return true;
        }

        public async Task<bool> DisableAccount(string username)
        {
            var user = await _usermanager.FindByNameAsync(username);
            user.IsActive = false;
            _context.AppUsers.Update(user);
            var result = await _context.SaveChangesAsync();
            return result > 0 ? true : false;
        }

        public async Task<bool> EnableAccount(string username)
        {
            var user = await _usermanager.FindByNameAsync(username);
            user.IsActive = true;
            _context.AppUsers.Update(user);
            var result = await _context.SaveChangesAsync();
            return result > 0 ? true : false;
        }

        public async Task<List<UserViewModel>> GetListUsers()
        {
            List<UserViewModel> ListUser = new List<UserViewModel>();

            var data = from c in _context.AppUsers
                       select new {c};
            foreach (var item in data)
            {
                List<string> rolelist = new List<string>();
                List<AppUserRole> roles = await _context.AppUserRoles.Where(x => x.UserId == item.c.Id).ToListAsync();
                
                foreach (var roleitem in roles)
                {
                    var role = await _context.AppRoles.FirstOrDefaultAsync(x => x.Id == roleitem.RoleId);
                    rolelist.Add(role.Name);
                }
                var dep  = await _context.Departments.FirstOrDefaultAsync(x => x.DepartmentId == item.c.IdDepartment);
                
                var user = new UserViewModel()
                {
                    Name = item.c.Name,
                    Department = dep != null ? dep.Name : null,
                    username = item.c.UserName,
                    Role = string.Join(", ",rolelist)
                };
                ListUser.Add(user);
            }
            return ListUser;
        }

        public async Task<bool> Register(RegisterRequest request)
        {
            var validation = new RegisterRequestValidator();
            var result_vali = await validation.ValidateAsync(request);
            if (result_vali.IsValid)
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
            return false;
        }

        public async Task<bool> ResetPassword(string username)
        {
            var user = await _usermanager.FindByNameAsync(username);
            var code = await _usermanager.GeneratePasswordResetTokenAsync(user);
            var result = await _usermanager.ResetPasswordAsync(user, code, "Mis@2022");
            return true;
        }
    }
}
