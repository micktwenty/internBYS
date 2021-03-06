using Complains_System.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.Extensions
{
    public static class ModelBuiderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BoardOfDirectors>().HasData(
               new BoardOfDirectors() {id = 1, name = "Nguyễn Mạnh Toàn", email = "ngmanhtoan@due.udn.vn", phone="0978456112" }
               );

            modelBuilder.Entity<Department>().HasData(
               new Department() {DepartmentId = 1,  Email = "ngquthien3520@gmail.com" , Name = "Kế toán"},
               new Department() {DepartmentId =  2, Email = "ngquthien3520@gmail.com" ,  Name = "Quản trị kinh doanh" }, 
               new Department() {DepartmentId =  3, Email = "ngquthien3520@gmail.com" , Name = "Marketing" },
               new Department() {DepartmentId =  4, Email = "ngquthien3520@gmail.com" ,  Name = "Du lịch" },
               new Department() {DepartmentId =  5, Email = "ngquthien3520@gmail.com" ,  Name = "Kinh doanh quốc tế" },
               new Department() {DepartmentId =  6, Email = "ngquthien3520@gmail.com" ,  Name = "Ngân hàng" }, 
               new Department() {DepartmentId =  7, Email = "ngquthien3520@gmail.com" ,  Name = "Tài chính" },
               new Department() {DepartmentId =  8, Email = "ngquthien3520@gmail.com" ,  Name = "Thống kê - Tin học" },
               new Department() {DepartmentId =  9, Email = "ngquthien3520@gmail.com" ,  Name = "Thương mại điện tử" }
               );
            modelBuilder.Entity<Student>().HasData(
               new Student() {Email = "181121521137@due.udn.vn" ,Studentcode = "181121521137", Name = "Nguyễn Quốc Thiện", DepartmentId = 1},
               new Student() {Email = "171121521050@due.udn.vn" ,Studentcode = "171121521050", Name = "Lê Linh Phương", DepartmentId = 2 },
               new Student() {Email = "191154833658@due.udn.vn" ,Studentcode = "191154833658", Name = "Trần Đức Duy Anh", DepartmentId = 3 },
               new Student() {Email = "181121521136@due.udn.vn" ,Studentcode = "181121521136", Name = "Nguyễn Quang Thành", DepartmentId = 4 },
               new Student() {Email = "181121521138@due.udn.vn" ,Studentcode = "181121521138", Name = "Nguyễn Duy Thông", DepartmentId = 5 },
               new Student() {Email = "191123659113@due.udn.vn" ,Studentcode = "191123659113", Name = "Nguyễn Minh", DepartmentId = 6 },
               new Student() {Email = "201154896335@due.udn.vn" ,Studentcode = "201154896335", Name = "Lê Hà Phước", DepartmentId = 7 },
               new Student() {Email = "201159871175@due.udn.vn" ,Studentcode = "201159871175", Name = "Nguyễn Thành Đô", DepartmentId = 8 },
               new Student() {Email = "171122225114@due.udn.vn", Studentcode = "171122225114", Name = "Hồ Tiểu Băng", DepartmentId = 9 }
                );
            modelBuilder.Entity<Employee>().HasData(
              new Employee() {Email = "danle@due.edu.vn", Id = 1  ,Name = "Lê Dân", DepartmentId = 1 },
              new Employee() {Email = "ha.htt@due.edu.vn", Id =  2 ,Name = "Hoàng Thị Thanh Hà", DepartmentId = 2 },
              new Employee() {Email = "nhamct@due.edu.vn", Id =  3, Name = "Cao Thị Nhâm", DepartmentId = 3 },
              new Employee() {Email = "khuethu@due.edu.vn", Id =  4 ,Name = "Võ Quang Trí", DepartmentId = 4 },
              new Employee() {Email = "voquangtri@due.edu.vn", Id =  5, Name = "Ngô Thị Khuê Thư", DepartmentId = 5 },
              new Employee() {Email = "danvn@due.edu.vn", Id =  6, Name = "Văn Ngọc Đàn", DepartmentId = 6 },
              new Employee() {Email = "van.ptb@due.edu.vn", Id =  7, Name = "Phan Thị Bích Vân", DepartmentId = 7 },
              new Employee() {Email = "thenb@due.edu.vn", Id =  8, Name = "Nguyễn Bá Thế", DepartmentId = 8 },
              new Employee() {Email = "thuynt@due.edu.vn", Id = 9, Name = "Nguyễn Thành Thủy", DepartmentId = 9 }
               );
            modelBuilder.Entity<Complain>().HasData(
              new Complain() {Title = "Phàn nàn" ,IdComplains= 1,Content ="Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",IdDepartment = 1, IdStudent = "181121521137" },
              new Complain() {Title = "Phàn nàn" ,IdComplains= 2,Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",IdDepartment = 2, IdStudent = "171121521050" },
              new Complain() {Title = "Phàn nàn" ,IdComplains= 3,Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",IdDepartment = 3, IdStudent = "191154833658" },
              new Complain() {Title = "Phàn nàn" ,IdComplains= 4,Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",IdDepartment = 4, IdStudent = "181121521136" },
              new Complain() {Title = "Phàn nàn" ,IdComplains= 5,Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",IdDepartment = 5, IdStudent = "181121521138" },
              new Complain() {Title = "Phàn nàn" ,IdComplains= 6,Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",IdDepartment = 6, IdStudent = "191123659113" },
              new Complain() {Title = "Phàn nàn" ,IdComplains= 7,Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",IdDepartment = 7, IdStudent = "201154896335" },
              new Complain() {Title = "Phàn nàn" ,IdComplains= 8,Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",IdDepartment = 8, IdStudent = "201159871175" },
              new Complain() {Title = "Phàn nàn",IdComplains = 11, Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", IdDepartment = 1, IdStudent = "181121521137", IsPublic =true },
              new Complain() {Title = "Phàn nàn",IdComplains = 12, Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", IdDepartment = 2, IdStudent = "171121521050", IsPublic =true },
              new Complain() {Title = "Phàn nàn",IdComplains = 13, Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", IdDepartment = 3, IdStudent = "191154833658", IsPublic =true },
              new Complain() {Title = "Phàn nàn",IdComplains = 14, Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", IdDepartment = 4, IdStudent = "181121521136", IsPublic =true },
              new Complain() {Title = "Phàn nàn",IdComplains = 15, Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", IdDepartment = 5, IdStudent = "181121521138", IsPublic =true },
              new Complain() {Title = "Phàn nàn",IdComplains = 16, Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", IdDepartment = 6, IdStudent = "191123659113", IsPublic =true },
              new Complain() {Title = "Phàn nàn",IdComplains = 17, Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", IdDepartment = 7, IdStudent = "201154896335", IsPublic =true },
              new Complain() {Title = "Phàn nàn",IdComplains = 18, Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", IdDepartment = 8, IdStudent = "201159871175", IsPublic = true },
              new Complain() { Title = "Phàn nàn", IdComplains = 21, Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", IdDepartment = 1, IdStudent = "181121521137", IsPublic =true },
              new Complain() { Title = "Phàn nàn", IdComplains = 22, Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", IdDepartment = 2, IdStudent = "171121521050", IsPublic =true },
              new Complain() { Title = "Phàn nàn", IdComplains = 23, Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", IdDepartment = 3, IdStudent = "191154833658", IsPublic =true },
              new Complain() { Title = "Phàn nàn", IdComplains = 24, Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", IdDepartment = 4, IdStudent = "181121521136", IsPublic = true },
              new Complain() { Title = "Phàn nàn", IdComplains = 25, Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", IdDepartment = 5, IdStudent = "181121521138" },
              new Complain() { Title = "Phàn nàn", IdComplains = 26, Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", IdDepartment = 6, IdStudent = "191123659113" },
              new Complain() { Title = "Phàn nàn", IdComplains = 27, Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", IdDepartment = 7, IdStudent = "201154896335" },
              new Complain() { Title = "Phàn nàn", IdComplains = 28, Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", IdDepartment = 8, IdStudent = "201159871175" },

              new Complain() {Title = "Phàn nàn" ,IdComplains= 9,Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",IdDepartment = 9, IdStudent = "171122225114" }
            );
            var roleId = "AE59A954-C5F1-419A-A3FF-38A4818EE3A0";
            var adminId = "40FB70EC-DBE5-46D0-A55A-A63E751E7AD5";
            modelBuilder.Entity<AppRole>().HasData(new AppRole
            {
                Id = roleId,
                Name = "admin",
                NormalizedName = "admin",
                Description = "Administrator role"
            },
            new AppRole
            {
                Id = "8E742903-5250-4C2C-829B-F1BAE8E7981B",
                Name = "student",
                NormalizedName = "student",
                Description = "student role"
            }, new AppRole
            {
                Id = "6BFD2AC2-5F05-4EA7-87D9-ECF95EE4A1D5",
                Name = "employee",
                NormalizedName = "employee",
                Description = "employee role"
            }, new AppRole
            {
                Id = "A639AE1A-D634-455C-BC58-E68883695BE2",
                Name = "board_of_director",
                NormalizedName = "Manager of Complains Department.",
                Description = "comlplains department role"
            }
            );

            var hasher = new PasswordHasher<AppUser>();
            modelBuilder.Entity<AppUser>().HasData(new AppUser
            {
                Id = adminId,
                UserName = "admin",
                NormalizedUserName = "admin",
                Email = "ngquthien3520@gmail.com",
                NormalizedEmail = "ngquthien3520@gmail.com",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Mis@2022"),
                SecurityStamp = string.Empty,
                Name = "Thien"
            },
            new AppUser
            {
                Id = "D7109CE2-34E7-4736-9687-4418A3973285",
                UserName = "ngmanhtoan@due.udn.vn",
                NormalizedUserName = "Toan",
                Email = "ngmanhtoan@due.udn.vn",
                NormalizedEmail = "ngmanhtoan@due.udn.vn",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Mis@2022"),
                SecurityStamp = string.Empty,
                Name = "Nguyễn Mạnh Toàn"
            });

            modelBuilder.Entity<AppUserRole>().ToTable("AppUserRoles").HasData(new AppUserRole
            {
                RoleId = roleId,
                UserId = adminId,
                username = "admin"
            },
            new AppUserRole
            {
                RoleId = "A639AE1A-D634-455C-BC58-E68883695BE2",
                UserId = "D7109CE2-34E7-4736-9687-4418A3973285",
                username = "ngmanhtoan@due.udn.vn"
            });
        }
    }
}
