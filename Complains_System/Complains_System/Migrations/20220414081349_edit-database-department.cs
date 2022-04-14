using Microsoft.EntityFrameworkCore.Migrations;

namespace Complains_System.Migrations
{
    public partial class editdatabasedepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "totalemployee",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "totalstudent",
                table: "Departments");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "6BFD2AC2-5F05-4EA7-87D9-ECF95EE4A1D5",
                column: "ConcurrencyStamp",
                value: "5a938add-a5ea-4b33-b5aa-33c9a16b6f4b");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "8E742903-5250-4C2C-829B-F1BAE8E7981B",
                column: "ConcurrencyStamp",
                value: "7c9ac610-4929-4bc5-bc43-9f1773ba49ac");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "A639AE1A-D634-455C-BC58-E68883695BE2",
                column: "ConcurrencyStamp",
                value: "58d3b646-c435-4b9f-8e1c-ba3d3fa20d4d");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "AE59A954-C5F1-419A-A3FF-38A4818EE3A0",
                column: "ConcurrencyStamp",
                value: "e7b95162-6338-4196-8390-f87bc881bb48");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "UserName",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eab169c5-350d-415a-8133-6300cb5aae9c", "AQAAAAEAACcQAAAAEAGeu1o7kLzHhmXRE9sp3DYBDsIphanv57mQWPq8ciMD2bJYwN7JpaVs7Kb4FBqNeQ==" });

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Email",
                value: "ngquthien3520@gmail.com");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Email",
                value: "ngquthien3520@gmail.com");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Email",
                value: "ngquthien3520@gmail.com");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4,
                column: "Email",
                value: "ngquthien3520@gmail.com");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 5,
                column: "Email",
                value: "ngquthien3520@gmail.com");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 6,
                column: "Email",
                value: "ngquthien3520@gmail.com");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 7,
                column: "Email",
                value: "ngquthien3520@gmail.com");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 8,
                column: "Email",
                value: "ngquthien3520@gmail.com");

            migrationBuilder.UpdateData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 9,
                column: "Email",
                value: "ngquthien3520@gmail.com");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Departments");

            migrationBuilder.AddColumn<int>(
                name: "totalemployee",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "totalstudent",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "6BFD2AC2-5F05-4EA7-87D9-ECF95EE4A1D5",
                column: "ConcurrencyStamp",
                value: "e92d9d30-18ec-48f7-8183-22ae14bd8bd2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "8E742903-5250-4C2C-829B-F1BAE8E7981B",
                column: "ConcurrencyStamp",
                value: "8763ed0b-a032-47a2-a45f-9e4e3764a3e6");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "A639AE1A-D634-455C-BC58-E68883695BE2",
                column: "ConcurrencyStamp",
                value: "0770afbc-4971-42ac-906d-a39e734b1cfa");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "AE59A954-C5F1-419A-A3FF-38A4818EE3A0",
                column: "ConcurrencyStamp",
                value: "7ad4e68f-56fd-4675-8893-b44a484b2b60");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "UserName",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6ef5b5ae-3727-42e1-a32c-f427cf368cb0", "AQAAAAEAACcQAAAAEOIFvIV6fCh+Fy2yItVcaJkXMXWpnz8WYgaOWQRDZFqhJsKwD4iix2nEE4669RsdSg==" });
        }
    }
}
