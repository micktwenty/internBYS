using Microsoft.EntityFrameworkCore.Migrations;

namespace Complains_System.Migrations
{
    public partial class addisactivecollumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AppUsers",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<string>(
                name: "Roles",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AppUsers");

            migrationBuilder.DropColumn(
                name: "Roles",
                table: "AppUsers");

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
    }
}
