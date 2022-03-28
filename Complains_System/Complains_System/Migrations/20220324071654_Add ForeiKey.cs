using Microsoft.EntityFrameworkCore.Migrations;

namespace Complains_System.Migrations
{
    public partial class AddForeiKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "6BFD2AC2-5F05-4EA7-87D9-ECF95EE4A1D5",
                column: "ConcurrencyStamp",
                value: "4c81ca03-3d88-49eb-8426-7b9d2e812ced");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "8E742903-5250-4C2C-829B-F1BAE8E7981B",
                column: "ConcurrencyStamp",
                value: "75c17756-a81c-4083-9d4f-66b884ac067d");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "AE59A954-C5F1-419A-A3FF-38A4818EE3A0",
                column: "ConcurrencyStamp",
                value: "0a688e5a-dfa3-4b98-9e0c-321d065babf0");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "UserName",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0fb0fa3b-6ace-43ed-b1d6-73c50d6cd968", "AQAAAAEAACcQAAAAEJ5Hc+v1DJ9ZuEi2vyYaCawprSm9peEwGYy+/3i5mnGnVG00au8a1XFoge4EMrRmRg==" });


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUserRoles_AppUsers_UserId",
                table: "AppUserRoles");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "6BFD2AC2-5F05-4EA7-87D9-ECF95EE4A1D5",
                column: "ConcurrencyStamp",
                value: "ad758572-1e4c-44d1-92a2-bbca8bb66d79");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "8E742903-5250-4C2C-829B-F1BAE8E7981B",
                column: "ConcurrencyStamp",
                value: "0e2abdc4-e477-4631-b715-9654c14bb015");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "AE59A954-C5F1-419A-A3FF-38A4818EE3A0",
                column: "ConcurrencyStamp",
                value: "c023a507-8ef9-4b38-b50f-3edfd14a632e");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "UserName",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99311530-b0bd-404a-9f6e-4328916e99d5", "AQAAAAEAACcQAAAAEOQfNGYX0LE9chehFv8wWvPL8up5IRzkvxnF/jQZ6wNA3J2HkSIeHwyhv4phMdr1Sw==" });
        }
    }
}
