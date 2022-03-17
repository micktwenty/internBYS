using Microsoft.EntityFrameworkCore.Migrations;

namespace Complains_System.Migrations
{
    public partial class seedingdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "IdentityUserRole<string>",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdentityUserRole<string>", x => new { x.UserId, x.RoleId });
                });

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "AE59A954-C5F1-419A-A3FF-38A4818EE3A0", "d6d656da-b29b-491b-aa35-fc65f51e4f21", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "IdDepartment", "IdStudent", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "idteacher" },
                values: new object[] { "40FB70EC-DBE5-46D0-A55A-A63E751E7AD5", 0, "5314cb4d-ac33-4601-a8b6-3c1c1b472190", "ngquthien3520@gmail.com", true, 0, null, false, null, "Thien", "ngquthien3520@gmail.com", "admin", "AQAAAAEAACcQAAAAEIOZGO/sa0fQZ84vQV07k+GwVa/ilJatQ3vh+i+29sim5GqAIWbu1srBWwfU4SuabA==", null, false, "", false, "admin", null });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "name", "phone", "totalemployee", "totalstudent" },
                values: new object[,]
                {
                    { 1, "Kế toán", null, null, null },
                    { 2, "Quản trị kinh doanh", null, null, null },
                    { 3, "Marketing", null, null, null },
                    { 4, "Du lịch", null, null, null },
                    { 5, "Kinh doanh quốc tế", null, null, null },
                    { 6, "Ngân hàng", null, null, null },
                    { 7, "Tài chính", null, null, null },
                    { 8, "Thống kê - Tin học", null, null, null },
                    { 9, "Thương mại điện tử", null, null, null }
                });

            migrationBuilder.InsertData(
                table: "IdentityUserRole<string>",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "AE59A954-C5F1-419A-A3FF-38A4818EE3A0", "40FB70EC-DBE5-46D0-A55A-A63E751E7AD5" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "id", "idDepartment", "Email", "name", "position" },
                values: new object[,]
                {
                    { 1, 1, "danle@due.edu.vn", "Lê Dân", null },
                    { 8, 8, "thenb@due.edu.vn", "Nguyễn Bá Thế", null },
                    { 7, 7, "van.ptb@due.edu.vn", "Phan Thị Bích Vân", null },
                    { 6, 6, "danvn@due.edu.vn", "Văn Ngọc Đàn", null },
                    { 9, 9, "thuynt@due.edu.vn", "Nguyễn Thành Thủy", null },
                    { 4, 4, "khuethu@due.edu.vn", "Võ Quang Trí", null },
                    { 5, 5, "voquangtri@due.edu.vn", "Ngô Thị Khuê Thư", null },
                    { 3, 3, "nhamct@due.edu.vn", "Cao Thị Nhâm", null },
                    { 2, 2, "ha.htt@due.edu.vn", "Hoàng Thị Thanh Hà", null }
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "studentcode", "DepartmentId", "email", "name", "phone", "sclass" },
                values: new object[,]
                {
                    { "181121521136", 4, "181121521136@due.udn.vn", "Nguyễn Quang Thành", null, null },
                    { "181121521138", 5, "181121521138@due.udn.vn", "Nguyễn Duy Thông", null, null },
                    { "171121521050", 2, "171121521050@due.udn.vn", "Lê Linh Phương", null, null },
                    { "191123659113", 6, "191123659113@due.udn.vn", "Nguyễn Minh", null, null },
                    { "201154896335", 7, "201154896335@due.udn.vn", "Lê Hà Phước", null, null },
                    { "181121521137", 1, "181121521137@due.udn.vn", "Nguyễn Quốc Thiện", null, null },
                    { "201159871175", 8, "201159871175@due.udn.vn", "Nguyễn Thành Đô", null, null },
                    { "191154833658", 3, "191154833658@due.udn.vn", "Trần Đức Duy Anh", null, null },
                    { "171122225114", 9, "171122225114@due.udn.vn", "Hồ Tiểu Băng", null, null }
                });

            migrationBuilder.InsertData(
                table: "complains",
                columns: new[] { "IdComplain", "Content", "IdDepartment", "IdStudent", "reply", "Title", "employee_reply" },
                values: new object[,]
                {
                    { 1, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 1, "181121521137", null, "Phàn nàn", null },
                    { 2, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 2, "171121521050", null, "Phàn nàn", null },
                    { 3, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 3, "191154833658", null, "Phàn nàn", null },
                    { 4, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 4, "181121521136", null, "Phàn nàn", null },
                    { 5, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 5, "181121521138", null, "Phàn nàn", null },
                    { 6, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 6, "191123659113", null, "Phàn nàn", null },
                    { 7, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 7, "201154896335", null, "Phàn nàn", null },
                    { 8, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 8, "201159871175", null, "Phàn nàn", null },
                    { 9, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 9, "171122225114", null, "Phàn nàn", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "IdentityUserRole<string>");

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "AE59A954-C5F1-419A-A3FF-38A4818EE3A0");

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: "40FB70EC-DBE5-46D0-A55A-A63E751E7AD5");

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "171121521050");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "171122225114");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "181121521136");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "181121521137");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "181121521138");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "191123659113");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "191154833658");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "201154896335");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "studentcode",
                keyValue: "201159871175");

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9);
        }
    }
}
