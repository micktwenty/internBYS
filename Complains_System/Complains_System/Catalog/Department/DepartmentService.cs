using Complains_System.EF;
using Complains_System.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Catalog.Department
{
    public class DepartmentService : IDepartmentService
    {
        private readonly ComplainsDbContext _context;


        public DepartmentService(ComplainsDbContext context)
        {

            _context = context;
        }

        public async Task<int> CreateDepartment(string Name)
        {
            var dep = new Complains_System.Models.Department()
            {
                Name = Name
            };
            _context.Departments.Add(dep);
            return await _context.SaveChangesAsync();

        }

        public async Task<int> DeleteDepartment(int id)
        {
            var department = await _context.Departments.FindAsync(id);
            _context.Departments.Remove(department);
            return await _context.SaveChangesAsync();
        }

        public async Task<int> EditDepartment(EditDepartmentRequest request)
        {
            var department = await _context.Departments.FindAsync(request.id);
            department.Name = request.name;
            return await _context.SaveChangesAsync();
        }

        public async Task<List<ListDepartments>> GetListDepartments()
        {
            var query = from c in _context.Departments
                        select c;
            var data = await query.Select(x => new ListDepartments()
            {
               Id = x.DepartmentId,
               Name = x.Name
            }).ToListAsync();
            return data;
        }
    }
}
