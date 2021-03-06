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
            modelBuilder.ApplyConfiguration(new AppUserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new AppUsersConfigurations());
            modelBuilder.ApplyConfiguration(new ImageComplainsConfigurations());
            modelBuilder.ApplyConfiguration(new StudentsConfigurations());
            modelBuilder.ApplyConfiguration(new BoardOfDirectorsConfigurations());

            //Data Seeding
            modelBuilder.Seed();

            modelBuilder.Entity<IdentityUserRole<string>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<AppUserRole>().ToTable("AppUserRoles");
            modelBuilder.Entity<IdentityRoleClaim<string>>().ToTable("AppRoleClaims");

            modelBuilder.Entity<IdentityUserClaim<string>>().ToTable("AppUserClaims");

        }
        public virtual DbSet<Complain> Complains { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<ImageComplain> ImageComplains { get; set; }
        public virtual DbSet<AppUser> AppUsers { get; set; }
        public virtual DbSet<AppUserRole> AppUserRoles { get; set; }
        public virtual DbSet<AppRole> AppRoles { get; set; }
        public virtual DbSet<BoardOfDirectors> BoardOfDirectors { get; set; }




    }
}
