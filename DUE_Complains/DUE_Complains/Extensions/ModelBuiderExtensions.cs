using DUE_Complains.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DUE_Complains.Extensions
{
    public static class ModelBuiderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is homepage of Solution" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is keyword of Solution" }
               );

            modelBuilder.Entity<Department>().HasData(
               new Department() {DepartmentId = 1,  Name = "Kế toán"},
               new Department() {DepartmentId =  2,  Name = "Quản trị kinh doanh" }, 
               new Department() {DepartmentId =  3, Name = "Marketing" },
               new Department() {DepartmentId =  4,  Name = "Du lịch" },
               new Department() {DepartmentId =  5,  Name = "Kinh doanh quốc tế" },
               new Department() {DepartmentId =  6,  Name = "Ngân hàng" }, 
               new Department() {DepartmentId =  7,  Name = "Tài chính" },
               new Department() {DepartmentId =  8,  Name = "Thống kê - Tin học" },
               new Department() {DepartmentId =  9,  Name = "Thương mại điện tử" }
               );
            modelBuilder.Entity<Student>().HasData(
               new Student() {Studentcode= "181121521137", Name = "Nguyễn Quốc Thiện", DepartmentId = 1 },
               new Student() { Studentcode = "171121521050", Name = "Lê Linh Phương", DepartmentId = 2 },
               new Student() { Studentcode = "191154833658", Name = "Trần Đức Duy Anh", DepartmentId = 3 },
               new Student() {Studentcode= "181121521136", Name = "Nguyễn Quang Thành", DepartmentId = 4 },
               new Student() { Studentcode = "181121521138", Name = "Nguyễn Duy Thông", DepartmentId = 5 },
               new Student() { Studentcode = "191123659113", Name = "Nguyễn Minh", DepartmentId = 6 },
               new Student() { Studentcode = "201154896335", Name = "Lê Hà Phước", DepartmentId = 7 },
               new Student() { Studentcode = "201159871175", Name = "Nguyễn Thành Đô", DepartmentId = 8 },
               new Student() { Studentcode = "171122225114", Name = "Hồ Tiểu Băng", DepartmentId = 9 }
                );
            modelBuilder.Entity<Employee>().HasData(
              new Employee() {Id = 1  ,Name = "Lê Dân", DepartmentId = 1 },
              new Employee() {Id =  2 ,Name = "Hoàng Thị Thanh Hà", DepartmentId = 2 },
              new Employee() {Id =  3, Name = "Cao Thị Nhâm", DepartmentId = 3 },
              new Employee() {Id =  4 ,Name = "Võ Quang Trí", DepartmentId = 4 },
              new Employee() {Id =  5, Name = "Ngô Thị Khuê Thư", DepartmentId = 5 },
              new Employee() {Id =  6, Name = "Văn Ngọc Đàn", DepartmentId = 6 },
              new Employee() {Id =  7, Name = "Phan Thị Bích Vân", DepartmentId = 7 },
              new Employee() {Id =  8, Name = "Nguyễn Bá Thế", DepartmentId = 8 },
              new Employee() {Id = 9, Name = "Nguyễn Thành Thủy", DepartmentId = 9 }
               );
            modelBuilder.Entity<Complain>().HasData(
              new Complain() {Title = "Phàn nàn" ,IdComplains=1 ,Content ="Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",IdDepartment = 1, IdStudent = "181121521137" },
              new Complain() {Title = "Phàn nàn" ,IdComplains= 2,Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",IdDepartment = 2, IdStudent = "171121521050" },
              new Complain() {Title = "Phàn nàn" ,IdComplains= 3,Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",IdDepartment = 3, IdStudent = "191154833658" },
              new Complain() {Title = "Phàn nàn" ,IdComplains= 4,Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",IdDepartment = 4, IdStudent = "181121521136" },
              new Complain() {Title = "Phàn nàn" ,IdComplains= 5,Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",IdDepartment = 5, IdStudent = "181121521138" },
              new Complain() {Title = "Phàn nàn" ,IdComplains= 6,Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",IdDepartment = 6, IdStudent = "191123659113" },
              new Complain() {Title = "Phàn nàn" ,IdComplains= 7,Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",IdDepartment = 7, IdStudent = "201154896335" },
              new Complain() {Title = "Phàn nàn" ,IdComplains= 8,Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",IdDepartment = 8, IdStudent = "201159871175" },
              new Complain() {Title = "Phàn nàn" ,IdComplains= 9,Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",IdDepartment = 9, IdStudent = "171122225114" }
   );                                                                                                                                                                                     
        }
    }
}
