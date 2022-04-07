using Microsoft.EntityFrameworkCore.Migrations;

namespace Complains_System.Migrations
{
    public partial class seedingdatanew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "6BFD2AC2-5F05-4EA7-87D9-ECF95EE4A1D5",
                column: "ConcurrencyStamp",
                value: "542c2acb-a0e1-4932-a181-45eafdb297d4");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "8E742903-5250-4C2C-829B-F1BAE8E7981B",
                column: "ConcurrencyStamp",
                value: "275d2909-1f7a-4199-8748-1e69c212fdcc");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "AE59A954-C5F1-419A-A3FF-38A4818EE3A0",
                column: "ConcurrencyStamp",
                value: "2571ab1b-da4a-4f7e-a8f7-20efa392dcfa");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "UserName",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "07f368ee-0756-4f84-9653-5393190f0a93", "AQAAAAEAACcQAAAAEAmb5r6ypOcP6Z59pjT0MP0Hkpb1i/Jv6SoodM3fK8FhSKm5yRXJOUrqI046fQVImg==" });

            migrationBuilder.InsertData(
                table: "complains",
                columns: new[] { "IdComplain", "Content", "IdDepartment", "IdStudent", "reply", "Title", "employee_reply" },
                values: new object[,]
                {
                    { 28, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 8, "201159871175", null, "Phàn nàn", null },
                    { 27, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 7, "201154896335", null, "Phàn nàn", null },
                    { 26, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 6, "191123659113", null, "Phàn nàn", null },
                    { 25, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 5, "181121521138", null, "Phàn nàn", null },
                    { 24, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 4, "181121521136", null, "Phàn nàn", null },
                    { 23, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 3, "191154833658", null, "Phàn nàn", null },
                    { 22, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 2, "171121521050", null, "Phàn nàn", null },
                    { 18, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 8, "201159871175", null, "Phàn nàn", null },
                    { 17, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 7, "201154896335", null, "Phàn nàn", null },
                    { 16, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 6, "191123659113", null, "Phàn nàn", null },
                    { 15, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 5, "181121521138", null, "Phàn nàn", null },
                    { 14, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 4, "181121521136", null, "Phàn nàn", null },
                    { 13, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 3, "191154833658", null, "Phàn nàn", null },
                    { 12, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 2, "171121521050", null, "Phàn nàn", null },
                    { 21, "Cơ sở vật chất nhà đa chức năng xuống cấp, không đảm bảo độ an toàn cho sinh viên khi sử dụng để phục vụ việc học", 1, "181121521137", null, "Phàn nàn", null },
                    
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 28);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "6BFD2AC2-5F05-4EA7-87D9-ECF95EE4A1D5",
                column: "ConcurrencyStamp",
                value: "9acb40ba-2eac-46b7-a7dc-79a2b2e56ca0");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "8E742903-5250-4C2C-829B-F1BAE8E7981B",
                column: "ConcurrencyStamp",
                value: "c509e559-a145-4e62-b22d-247eb3f64ff6");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "AE59A954-C5F1-419A-A3FF-38A4818EE3A0",
                column: "ConcurrencyStamp",
                value: "b9d9e60a-da18-4b85-9e06-885fd87d5c69");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "UserName",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0d896d4e-38da-42d2-8602-48b8cffb9cf3", "AQAAAAEAACcQAAAAEC8Pkaj8fBj+Sd1RMLF/+N4h3gP9tpz+nqMefOpXbEeoO+TbPLM7Kra8ECJFQw1cLw==" });
        }
    }
}
