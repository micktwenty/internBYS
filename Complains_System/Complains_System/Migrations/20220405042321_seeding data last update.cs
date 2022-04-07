using Microsoft.EntityFrameworkCore.Migrations;

namespace Complains_System.Migrations
{
    public partial class seedingdatalastupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 11,
                column: "IsPublic",
                value: true);

            migrationBuilder.UpdateData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 12,
                column: "IsPublic",
                value: true);

            migrationBuilder.UpdateData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 13,
                column: "IsPublic",
                value: true);

            migrationBuilder.UpdateData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 14,
                column: "IsPublic",
                value: true);

            migrationBuilder.UpdateData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 15,
                column: "IsPublic",
                value: true);

            migrationBuilder.UpdateData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 16,
                column: "IsPublic",
                value: true);

            migrationBuilder.UpdateData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 17,
                column: "IsPublic",
                value: true);

            migrationBuilder.UpdateData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 18,
                column: "IsPublic",
                value: true);

            migrationBuilder.UpdateData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 21,
                column: "IsPublic",
                value: true);

            migrationBuilder.UpdateData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 22,
                column: "IsPublic",
                value: true);

            migrationBuilder.UpdateData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 23,
                column: "IsPublic",
                value: true);

            migrationBuilder.UpdateData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 24,
                column: "IsPublic",
                value: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 11,
                column: "IsPublic",
                value: false);

            migrationBuilder.UpdateData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 12,
                column: "IsPublic",
                value: false);

            migrationBuilder.UpdateData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 13,
                column: "IsPublic",
                value: false);

            migrationBuilder.UpdateData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 14,
                column: "IsPublic",
                value: false);

            migrationBuilder.UpdateData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 15,
                column: "IsPublic",
                value: false);

            migrationBuilder.UpdateData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 16,
                column: "IsPublic",
                value: false);

            migrationBuilder.UpdateData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 17,
                column: "IsPublic",
                value: false);

            migrationBuilder.UpdateData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 18,
                column: "IsPublic",
                value: false);

            migrationBuilder.UpdateData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 21,
                column: "IsPublic",
                value: false);

            migrationBuilder.UpdateData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 22,
                column: "IsPublic",
                value: false);

            migrationBuilder.UpdateData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 23,
                column: "IsPublic",
                value: false);

            migrationBuilder.UpdateData(
                table: "complains",
                keyColumn: "IdComplain",
                keyValue: 24,
                column: "IsPublic",
                value: false);
        }
    }
}
