// <auto-generated />
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
    [Migration("20220317064452_seeding-data-update")]
    partial class seedingdataupdate
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

                    b.HasData(
                        new
                        {
                            Id = "AE59A954-C5F1-419A-A3FF-38A4818EE3A0",
                            ConcurrencyStamp = "fcd1517d-421d-4085-ab34-90a5778190f2",
                            Description = "Administrator role",
                            Name = "admin",
                            NormalizedName = "admin"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = "40FB70EC-DBE5-46D0-A55A-A63E751E7AD5",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8165f4b5-6f40-468d-80fb-aba00599cd05",
                            Email = "ngquthien3520@gmail.com",
                            EmailConfirmed = true,
                            IdDepartment = 0,
                            LockoutEnabled = false,
                            Name = "Thien",
                            NormalizedEmail = "ngquthien3520@gmail.com",
                            NormalizedUserName = "admin",
                            PasswordHash = "AQAAAAEAACcQAAAAECdD2nBXDagIz4owbEl+8DEGmzicK+AqGEIKsK7Z40RUfn0lomxe79Spx4di4fwUrw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "admin"
                        });
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

                    b.HasData(
                        new
                        {
                            IdComplains = 1,
                            Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",
                            IdDepartment = 1,
                            IdStudent = "181121521137",
                            IsPublic = false,
                            Title = "Phàn nàn"
                        },
                        new
                        {
                            IdComplains = 2,
                            Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",
                            IdDepartment = 2,
                            IdStudent = "171121521050",
                            IsPublic = false,
                            Title = "Phàn nàn"
                        },
                        new
                        {
                            IdComplains = 3,
                            Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",
                            IdDepartment = 3,
                            IdStudent = "191154833658",
                            IsPublic = false,
                            Title = "Phàn nàn"
                        },
                        new
                        {
                            IdComplains = 4,
                            Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",
                            IdDepartment = 4,
                            IdStudent = "181121521136",
                            IsPublic = false,
                            Title = "Phàn nàn"
                        },
                        new
                        {
                            IdComplains = 5,
                            Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",
                            IdDepartment = 5,
                            IdStudent = "181121521138",
                            IsPublic = false,
                            Title = "Phàn nàn"
                        },
                        new
                        {
                            IdComplains = 6,
                            Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",
                            IdDepartment = 6,
                            IdStudent = "191123659113",
                            IsPublic = false,
                            Title = "Phàn nàn"
                        },
                        new
                        {
                            IdComplains = 7,
                            Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",
                            IdDepartment = 7,
                            IdStudent = "201154896335",
                            IsPublic = false,
                            Title = "Phàn nàn"
                        },
                        new
                        {
                            IdComplains = 8,
                            Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",
                            IdDepartment = 8,
                            IdStudent = "201159871175",
                            IsPublic = false,
                            Title = "Phàn nàn"
                        },
                        new
                        {
                            IdComplains = 9,
                            Content = "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học",
                            IdDepartment = 9,
                            IdStudent = "171122225114",
                            IsPublic = false,
                            Title = "Phàn nàn"
                        });
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

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            Name = "Kế toán"
                        },
                        new
                        {
                            DepartmentId = 2,
                            Name = "Quản trị kinh doanh"
                        },
                        new
                        {
                            DepartmentId = 3,
                            Name = "Marketing"
                        },
                        new
                        {
                            DepartmentId = 4,
                            Name = "Du lịch"
                        },
                        new
                        {
                            DepartmentId = 5,
                            Name = "Kinh doanh quốc tế"
                        },
                        new
                        {
                            DepartmentId = 6,
                            Name = "Ngân hàng"
                        },
                        new
                        {
                            DepartmentId = 7,
                            Name = "Tài chính"
                        },
                        new
                        {
                            DepartmentId = 8,
                            Name = "Thống kê - Tin học"
                        },
                        new
                        {
                            DepartmentId = 9,
                            Name = "Thương mại điện tử"
                        });
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DepartmentId = 1,
                            Email = "danle@due.edu.vn",
                            Name = "Lê Dân"
                        },
                        new
                        {
                            Id = 2,
                            DepartmentId = 2,
                            Email = "ha.htt@due.edu.vn",
                            Name = "Hoàng Thị Thanh Hà"
                        },
                        new
                        {
                            Id = 3,
                            DepartmentId = 3,
                            Email = "nhamct@due.edu.vn",
                            Name = "Cao Thị Nhâm"
                        },
                        new
                        {
                            Id = 4,
                            DepartmentId = 4,
                            Email = "khuethu@due.edu.vn",
                            Name = "Võ Quang Trí"
                        },
                        new
                        {
                            Id = 5,
                            DepartmentId = 5,
                            Email = "voquangtri@due.edu.vn",
                            Name = "Ngô Thị Khuê Thư"
                        },
                        new
                        {
                            Id = 6,
                            DepartmentId = 6,
                            Email = "danvn@due.edu.vn",
                            Name = "Văn Ngọc Đàn"
                        },
                        new
                        {
                            Id = 7,
                            DepartmentId = 7,
                            Email = "van.ptb@due.edu.vn",
                            Name = "Phan Thị Bích Vân"
                        },
                        new
                        {
                            Id = 8,
                            DepartmentId = 8,
                            Email = "thenb@due.edu.vn",
                            Name = "Nguyễn Bá Thế"
                        },
                        new
                        {
                            Id = 9,
                            DepartmentId = 9,
                            Email = "thuynt@due.edu.vn",
                            Name = "Nguyễn Thành Thủy"
                        });
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

                    b.HasData(
                        new
                        {
                            Studentcode = "181121521137",
                            DepartmentId = 1,
                            Email = "181121521137@due.udn.vn",
                            Name = "Nguyễn Quốc Thiện"
                        },
                        new
                        {
                            Studentcode = "171121521050",
                            DepartmentId = 2,
                            Email = "171121521050@due.udn.vn",
                            Name = "Lê Linh Phương"
                        },
                        new
                        {
                            Studentcode = "191154833658",
                            DepartmentId = 3,
                            Email = "191154833658@due.udn.vn",
                            Name = "Trần Đức Duy Anh"
                        },
                        new
                        {
                            Studentcode = "181121521136",
                            DepartmentId = 4,
                            Email = "181121521136@due.udn.vn",
                            Name = "Nguyễn Quang Thành"
                        },
                        new
                        {
                            Studentcode = "181121521138",
                            DepartmentId = 5,
                            Email = "181121521138@due.udn.vn",
                            Name = "Nguyễn Duy Thông"
                        },
                        new
                        {
                            Studentcode = "191123659113",
                            DepartmentId = 6,
                            Email = "191123659113@due.udn.vn",
                            Name = "Nguyễn Minh"
                        },
                        new
                        {
                            Studentcode = "201154896335",
                            DepartmentId = 7,
                            Email = "201154896335@due.udn.vn",
                            Name = "Lê Hà Phước"
                        },
                        new
                        {
                            Studentcode = "201159871175",
                            DepartmentId = 8,
                            Email = "201159871175@due.udn.vn",
                            Name = "Nguyễn Thành Đô"
                        },
                        new
                        {
                            Studentcode = "171122225114",
                            DepartmentId = 9,
                            Email = "171122225114@due.udn.vn",
                            Name = "Hồ Tiểu Băng"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.ToTable("AppUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "40FB70EC-DBE5-46D0-A55A-A63E751E7AD5",
                            RoleId = "AE59A954-C5F1-419A-A3FF-38A4818EE3A0"
                        });
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
