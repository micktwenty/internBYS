using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace DUE_Complains.Models
{
    public partial class Complains_DUEContext : DbContext
    {
        public Complains_DUEContext()
        {
        }

        public Complains_DUEContext(DbContextOptions<Complains_DUEContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Complain> Complains { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<ImageComplain> ImageComplains { get; set; }


        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //                optionsBuilder.UseSqlServer("Server=LAPTOP-BM60O6G9\\THIEN_LAPTOP;Database=Complains_DUE;UID=sa;PWD=27040406");
        //            }
        //        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.HasKey(e => e.Username)
                    .HasName("PK__Accounts__F3DBC573CFD62F70");

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Role).HasColumnName("role");
            });

            modelBuilder.Entity<Complain>(entity =>
            {
                entity.HasKey(e => e.IdComplains)
                    .HasName("PK__complain__DC12E46E98597387");

                entity.ToTable("complains");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IdStudent)
                    .HasMaxLength(225)
                    .IsUnicode(false);

                //entity.Property(e => e.Picture).IsUnicode(false);

                //entity.Property(e => e.Picturecontent).HasColumnName("picturecontent");

                entity.Property(e => e.Reply).HasColumnName("reply");

                entity.Property(e => e.Status).HasColumnName("status")
                    .HasDefaultValueSql("N'Bản nháp'");

                entity.Property(e => e.Title).HasMaxLength(225);

                entity.Property(e => e.IsPublic).HasColumnName("IsPublic")
                    .HasDefaultValueSql("0");
                

                entity.HasOne(d => d.IdDepartmentNavigation)
                    .WithMany(p => p.Complains)
                    .HasForeignKey(d => d.IdDepartment)
                    .HasConstraintName("FK__complains__IdDep__2C3393D0");
                

                entity.HasOne(d => d.IdStudentNavigation)
                    .WithMany(p => p.Complains)
                    .HasForeignKey(d => d.IdStudent)
                    .HasConstraintName("FK__complains__IdStu__2D27B809");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Name)
                    .HasMaxLength(225)
                    .HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("phone")
                    .IsFixedLength(true);

                entity.Property(e => e.Totalemployee).HasColumnName("totalemployee");

                entity.Property(e => e.Totalstudent).HasColumnName("totalstudent");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdDepartment).HasColumnName("idDepartment");

                entity.Property(e => e.Name)
                    .HasMaxLength(225)
                    .HasColumnName("name");

                entity.Property(e => e.Picture)
                    .IsUnicode(false)
                    .HasColumnName("picture");

                entity.Property(e => e.Position)
                    .HasMaxLength(225)
                    .HasColumnName("position");

                entity.Property(e => e.Username)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("username");

                entity.HasOne(d => d.IdDepartmentNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.IdDepartment)
                    .HasConstraintName("FK__Employees__idDep__2E1BDC42");

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("FK__Employees__usern__4222D4EF");
            });
            modelBuilder.Entity<ImageComplain>(entity =>
            {
                entity.ToTable("ImageComplain");

                entity.HasKey(e => e.id)
                .HasName("PK__ImageCom__3213E83F160F617E");
                entity.Property(e => e.id)
                .HasColumnName("id");

                entity.Property(e => e.IdComplain)
                .HasColumnName("IdComplain")
                .IsRequired(true);
                entity.HasOne(d => d.complain)
                .WithMany(x => x.ImageComplain)
                .HasForeignKey(d => d.IdComplain)
                .HasConstraintName("FK__ImageComp__IdCom__73BA3083");

                entity.Property(e => e.sortOrder)
               .HasColumnName("SortOrder")
               .IsRequired(true);

                entity.Property(e => e.content_image)
                .HasColumnName("content_image");

                entity.Property(e => e.filesize)
                .HasColumnName("filesize");

                entity.Property(e => e.IsDefault)
                .HasColumnName("IsDefault")
                .IsRequired(true);

                entity.Property(e => e.Path_image)
                .HasColumnName("Path_image")
                .IsRequired(true);

            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.HasKey(e => e.Studentcode)
                    .HasName("PK__Students__A5703329F248FB09");

                entity.Property(e => e.Studentcode)
                    .HasMaxLength(225)
                    .IsUnicode(false)
                    .HasColumnName("studentcode");

                entity.Property(e => e.Email)
                    .HasMaxLength(256)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Name).HasColumnName("name");

                entity.Property(e => e.Phone)
                    .HasMaxLength(11)
                    .IsUnicode(false)
                    .HasColumnName("phone");

                entity.Property(e => e.Sclass)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sclass");

                entity.HasOne(d => d.DepartmentNavigation)
                    .WithMany(p => p.Students)
                    .HasForeignKey(d => d.Department)
                    .HasConstraintName("FK__Students__Depart__4AB81AF0");

                entity.HasOne(d => d.StudentcodeNavigation)
                    .WithOne(p => p.Student)
                    .HasForeignKey<Student>(d => d.Studentcode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Students__studen__6E01572D");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
