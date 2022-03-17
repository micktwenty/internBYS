using Complains_System.Configurations;
using Complains_System.Extensions;
using Complains_System.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Complains_System.EF
{
    public class ComplainsDbContext : DbContext
    {
        public ComplainsDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configure dufng Fluent API

            modelBuilder.ApplyConfiguration(new ComplainConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfigurations());
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new AppRolesConfigurations());
            modelBuilder.ApplyConfiguration(new AppUsersConfigurations());
            modelBuilder.ApplyConfiguration(new ImageComplainsConfigurations());
            modelBuilder.ApplyConfiguration(new StudentsConfigurations());
            //Data Seeding
            modelBuilder.Seed();

            modelBuilder.Entity<IdentityUserRole<string>>().HasKey(x => new { x.UserId, x.RoleId });

        }
        public virtual DbSet<Complain> Complains { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<ImageComplain> ImageComplains { get; set; }

           

    }
}
