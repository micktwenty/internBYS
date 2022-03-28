using Microsoft.EntityFrameworkCore.Migrations;

namespace Complains_System.Migrations
{
    public partial class addrole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {


            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "AE59A954-C5F1-419A-A3FF-38A4818EE3A0",
                column: "ConcurrencyStamp",
                value: "c023a507-8ef9-4b38-b50f-3edfd14a632e");

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8E742903-5250-4C2C-829B-F1BAE8E7981B", "0e2abdc4-e477-4631-b715-9654c14bb015", "student role", "student", "student" },
                    { "6BFD2AC2-5F05-4EA7-87D9-ECF95EE4A1D5", "ad758572-1e4c-44d1-92a2-bbca8bb66d79", "employee role", "employee", "employee" }
                });



            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "UserName",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99311530-b0bd-404a-9f6e-4328916e99d5", "AQAAAAEAACcQAAAAEOQfNGYX0LE9chehFv8wWvPL8up5IRzkvxnF/jQZ6wNA3J2HkSIeHwyhv4phMdr1Sw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "6BFD2AC2-5F05-4EA7-87D9-ECF95EE4A1D5");

            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "8E742903-5250-4C2C-829B-F1BAE8E7981B");

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "AE59A954-C5F1-419A-A3FF-38A4818EE3A0", "40FB70EC-DBE5-46D0-A55A-A63E751E7AD5" });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "AE59A954-C5F1-419A-A3FF-38A4818EE3A0",
                column: "ConcurrencyStamp",
                value: "804e2bae-4eb2-4638-a986-ffdd3dc9bab0");

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[] { "AE59A954-C5F1-419A-A3FF-38A4818EE3A0", "admin", "IdentityUserRole<string>" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "UserName",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "685af936-7c84-44c7-9836-55c8ba4870b9", "AQAAAAEAACcQAAAAEKplUYs2A/Ik6GkN68GlfSLDgtIWkSME0fhvZ/wekbHEZpNvLDPA/B/sVbki1jfykQ==" });
        }
    }
}
