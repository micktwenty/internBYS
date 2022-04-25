using Complains_System.Catalog.Admin;
using Complains_System.Catalog.Admin.DepartmentManagement.Dtos;
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
        private readonly IMailService _mailService;



        public DepartmentService(ComplainsDbContext context, IMailService mail)
        {

            _context = context;
            _mailService = mail;
        }

        public async Task<int> CreateDepartment(CreateRequest request)
        {
            var dep = new Complains_System.Models.Department()
            {
                Name = request.Name,
                Email = request.email,
                Phone = request.phone

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
            department.Phone = request.phone;
            department.Email = request.email;
            return await _context.SaveChangesAsync();
        }

        public async Task<List<ListDepartments>> GetListDepartments()
        {
            var query = from c in _context.Departments
                        select c;
            var data = await query.Select(x => new ListDepartments()
            {
                Id = x.DepartmentId,
                Name = x.Name,
                phone = x.Phone,
                email = x.Email
                
            }).ToListAsync();
            return data;
        }


        public async Task SendWarning(int id)
        {
            var department = await _context.Departments.FindAsync(id);

            var mail = new MailRequest()
            {
                Body = $"Chào phòng/ban <b>{department.Name}</b>," +
                $"Sau khi xem qua thống kê, chúng tôi nhận thấy các bạn vẫn chưa có động thái quan tâm đến" +
                $" phản ánh của sinh viên và đối tác. Đề nghị các bạn làm việc nghiêm túc hơn. Nhanh chóng giải quyết các vấn đề liên quan đến phòng/ban " +
                $"trên trang web <b>\"Complains DUE\"</b>. <br> -- <b>Ban giám hiệu trường Đại học Kinh Tế Đà Nẵng</b>.",
                Subject = "Thư cảnh báo",
                ToEmail = department.Email

            };
            await _mailService.SendEmailAsync(mail);
           
        }
    }

}
