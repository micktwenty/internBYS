﻿// <auto-generated />
using System;
using Complains_System.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Complains_System.Migrations
{
    [DbContext(typeof(ComplainsDbContext))]
    [Migration("20220317045126_Initial2")]
    partial class Initial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.15")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Complains_System.Models.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("AppRoles");
                });

            modelBuilder.Entity("Complains_System.Models.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("IdDepartment")
                        .HasColumnType("int");

                    b.Property<string>("IdStudent")
                        .HasMaxLength(225)
                        .HasColumnType("nvarchar(225)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("idteacher")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("Complains_System.Models.Complain", b =>
                {
                    b.Property<int>("IdComplains")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("IdComplain")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .IsRequired()
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Date")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime")
                        .HasColumnName("date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("IdDepartment")
                        .HasColumnType("int")
                        .HasColumnName("IdDepartment");

                    b.Property<string>("IdStudent")
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)");

                    b.Property<bool>("IsPublic")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bit")
                        .HasColumnName("IsPublic")
                        .HasDefaultValueSql("0");

                    b.Property<string>("Reply")
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("reply");

                    b.Property<string>("Status")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("status")
                        .HasDefaultValueSql("N'Bản nháp'");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(225)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(225)");

                    b.Property<int?>("employee_reply")
                        .HasColumnType("int")
                        .HasColumnName("employee_reply");

                    b.HasKey("IdComplains")
                        .HasName("PK__complain__DC12E46E98597387");

                    b.HasIndex("IdDepartment");

                    b.HasIndex("IdStudent");

                    b.HasIndex("employee_reply");

                    b.ToTable("complains");
                });

            modelBuilder.Entity("Complains_System.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(225)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(225)")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("char(11)")
                        .HasColumnName("phone")
                        .IsFixedLength(true);

                    b.Property<int?>("Totalemployee")
                        .HasColumnType("int")
                        .HasColumnName("totalemployee");

                    b.Property<int?>("Totalstudent")
                        .HasColumnType("int")
                        .HasColumnName("totalstudent");

                    b.HasKey("DepartmentId")
                        .HasName("PK__Departme__3214EC07150FB4F0");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Complains_System.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int")
                        .HasColumnName("idDepartment");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("Email");

                    b.Property<string>("Name")
                        .HasMaxLength(225)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(225)")
                        .HasColumnName("name");

                    b.Property<string>("Position")
                        .HasMaxLength(225)
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(225)")
                        .HasColumnName("position");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Complains_System.Models.ImageComplain", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdComplain")
                        .HasColumnType("int")
                        .HasColumnName("IdComplain");

                    b.Property<string>("Path_image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Path_image");

                    b.Property<string>("content_image")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("content_image");

                    b.Property<int>("filesize")
                        .HasColumnType("int")
                        .HasColumnName("filesize");

                    b.HasKey("id")
                        .HasName("PK__ImageCom__3213E83F160F617E");

                    b.HasIndex("IdComplain");

                    b.ToTable("ImageComplain");
                });

            modelBuilder.Entity("Complains_System.Models.Student", b =>
                {
                    b.Property<string>("Studentcode")
                        .HasMaxLength(225)
                        .IsUnicode(false)
                        .HasColumnType("varchar(225)")
                        .HasColumnName("studentcode");

                    b.Property<int?>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .IsUnicode(false)
                        .HasColumnType("varchar(256)")
                        .HasColumnName("email");

                    b.Property<string>("Name")
                        .IsUnicode(true)
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<string>("Phone")
                        .HasMaxLength(11)
                        .IsUnicode(false)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("phone");

                    b.Property<string>("Sclass")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("sclass");

                    b.HasKey("Studentcode")
                        .HasName("PK__Students__A5703329F248FB09");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("Complains_System.Models.Complain", b =>
                {
                    b.HasOne("Complains_System.Models.Department", "Department")
                        .WithMany("Complains")
                        .HasForeignKey("IdDepartment")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Complains_System.Models.Student", "IdStudentNavigation")
                        .WithMany("Complains")
                        .HasForeignKey("IdStudent")
                        .HasConstraintName("FK__complains__IdStu__2D27B809");

                    b.HasOne("Complains_System.Models.Employee", "Employee")
                        .WithMany("Idcomplains")
                        .HasForeignKey("employee_reply");

                    b.Navigation("Department");

                    b.Navigation("Employee");

                    b.Navigation("IdStudentNavigation");
                });

            modelBuilder.Entity("Complains_System.Models.Employee", b =>
                {
                    b.HasOne("Complains_System.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .HasConstraintName("FK__Employees__idDep__2E1BDC42")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Complains_System.Models.ImageComplain", b =>
                {
                    b.HasOne("Complains_System.Models.Complain", "complain")
                        .WithMany("ImageComplain")
                        .HasForeignKey("IdComplain")
                        .HasConstraintName("FK__ImageComp__IdCom__73BA3083")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("complain");
                });

            modelBuilder.Entity("Complains_System.Models.Student", b =>
                {
                    b.HasOne("Complains_System.Models.Department", "DepartmentNavi")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentId");

                    b.Navigation("DepartmentNavi");
                });

            modelBuilder.Entity("Complains_System.Models.Complain", b =>
                {
                    b.Navigation("ImageComplain");
                });

            modelBuilder.Entity("Complains_System.Models.Department", b =>
                {
                    b.Navigation("Complains");

                    b.Navigation("Employees");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("Complains_System.Models.Employee", b =>
                {
                    b.Navigation("Idcomplains");
                });

            modelBuilder.Entity("Complains_System.Models.Student", b =>
                {
                    b.Navigation("Complains");
                });
#pragma warning restore 612, 618
        }
    }
}
