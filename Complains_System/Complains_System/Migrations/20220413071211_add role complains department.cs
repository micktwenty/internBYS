using Microsoft.EntityFrameworkCore.Migrations;

namespace Complains_System.Migrations
{
    public partial class addrolecomplainsdepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

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
                keyValue: "AE59A954-C5F1-419A-A3FF-38A4818EE3A0",
                column: "ConcurrencyStamp",
                value: "7ad4e68f-56fd-4675-8893-b44a484b2b60");

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { "A639AE1A-D634-455C-BC58-E68883695BE2", "0770afbc-4971-42ac-906d-a39e734b1cfa", "comlplains department role", "complain_department", "Manager of Complains Department." });



            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "UserName",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6ef5b5ae-3727-42e1-a32c-f427cf368cb0", "AQAAAAEAACcQAAAAEOIFvIV6fCh+Fy2yItVcaJkXMXWpnz8WYgaOWQRDZFqhJsKwD4iix2nEE4669RsdSg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "A639AE1A-D634-455C-BC58-E68883695BE2");

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "AE59A954-C5F1-419A-A3FF-38A4818EE3A0", "40FB70EC-DBE5-46D0-A55A-A63E751E7AD5" });

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

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[] { "AE59A954-C5F1-419A-A3FF-38A4818EE3A0", "40FB70EC-DBE5-46D0-A55A-A63E751E7AD5", "IdentityUserRole<string>" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "UserName",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99c966c0-157a-4ecd-80f4-4217e9e6271c", "AQAAAAEAACcQAAAAECCwmPh67/62iW7Uu5+lKjWuyRSxEetQ1mz2s+Vc0t4yabJAiL/htn8r3sVrnFWzNQ==" });
        }
    }
}
