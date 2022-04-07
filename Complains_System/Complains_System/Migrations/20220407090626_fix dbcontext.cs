using Microsoft.EntityFrameworkCore.Migrations;

namespace Complains_System.Migrations
{
    public partial class fixdbcontext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AppUserRoles"
                );

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUserRoles_AppUsers_AppUserUserName",
                table: "AppUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AppUserRoles_AppUserUserName",
                table: "AppUserRoles");

            migrationBuilder.DropColumn(
                name: "AppUserUserName",
                table: "AppUserRoles");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "6BFD2AC2-5F05-4EA7-87D9-ECF95EE4A1D5",
                column: "ConcurrencyStamp",
                value: "08203876-9c45-455c-8a67-7959dc5bf152");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "8E742903-5250-4C2C-829B-F1BAE8E7981B",
                column: "ConcurrencyStamp",
                value: "86916293-f2f8-4a57-b1db-3ffe3bfcc5e1");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "AE59A954-C5F1-419A-A3FF-38A4818EE3A0",
                column: "ConcurrencyStamp",
                value: "8784570f-4b55-477b-a028-dba20dfceb87");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "UserName",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "807fc15e-b325-401e-9651-3b872cf0994c", "AQAAAAEAACcQAAAAEJGuMplpBreA5nhyj0fOu48EJJGYH4ZxGE03aRf3Q6P7lBPKKPsMIUf/jQT+S9djJg==" });

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserRoles_AppUsers_UserId",
                table: "AppUserRoles",
                column: "UserId",
                principalTable: "AppUsers",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
