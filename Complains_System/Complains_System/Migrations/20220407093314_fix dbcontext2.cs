using Microsoft.EntityFrameworkCore.Migrations;

namespace Complains_System.Migrations
{
    public partial class fixdbcontext2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "6BFD2AC2-5F05-4EA7-87D9-ECF95EE4A1D5",
                column: "ConcurrencyStamp",
                value: "843c644d-f501-4546-91cc-6503605f9f26");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "8E742903-5250-4C2C-829B-F1BAE8E7981B",
                column: "ConcurrencyStamp",
                value: "2038fafc-89f1-42fc-99c1-415481cb8ba2");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "AE59A954-C5F1-419A-A3FF-38A4818EE3A0",
                column: "ConcurrencyStamp",
                value: "018ad76c-ea07-4f9e-9708-842c41923ba4");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "UserName",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99c966c0-157a-4ecd-80f4-4217e9e6271c", "AQAAAAEAACcQAAAAECCwmPh67/62iW7Uu5+lKjWuyRSxEetQ1mz2s+Vc0t4yabJAiL/htn8r3sVrnFWzNQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "6BFD2AC2-5F05-4EA7-87D9-ECF95EE4A1D5",
                column: "ConcurrencyStamp",
                value: "a026b409-3bbe-46fa-a63a-5eaaa2af0709");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "8E742903-5250-4C2C-829B-F1BAE8E7981B",
                column: "ConcurrencyStamp",
                value: "0bc50eb9-7a7e-411e-bc12-f71a6e760611");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "AE59A954-C5F1-419A-A3FF-38A4818EE3A0",
                column: "ConcurrencyStamp",
                value: "fa00d6c9-b9c3-4dc8-bf53-b26d585bb694");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "UserName",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99ab017d-3791-4411-9563-91efdde40b11", "AQAAAAEAACcQAAAAEG+9GZ6W2afn817OA0w8xbNeeLUvGOhQSbjjWGtwwTpnviMGO0PqmYgQVZLDiVpCfQ==" });
        }
    }
}
