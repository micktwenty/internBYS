using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Catalog.Department
{
    public interface IDepartmentService
    {
        Task<List<ListDepartments>> GetListDepartments();
        public Task<int> CreateDepartment(CreateRequest request);
        public Task<int> DeleteDepartment(int id);
        public Task<int> EditDepartment(EditDepartmentRequest request);
        public Task SendWarning(int id);
        public Task<Complains_System.Models.Department> GetDepartment(int id);


    }
}
