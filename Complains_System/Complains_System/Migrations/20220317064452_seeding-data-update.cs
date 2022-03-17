using Microsoft.EntityFrameworkCore.Migrations;

namespace Complains_System.Migrations
{
    public partial class seedingdataupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_IdentityUserRole<string>",
                table: "IdentityUserRole<string>");

            migrationBuilder.RenameTable(
                name: "IdentityUserRole<string>",
                newName: "AppUserRoles");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserRoles",
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "AE59A954-C5F1-419A-A3FF-38A4818EE3A0",
                column: "ConcurrencyStamp",
                value: "fcd1517d-421d-4085-ab34-90a5778190f2");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: "40FB70EC-DBE5-46D0-A55A-A63E751E7AD5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8165f4b5-6f40-468d-80fb-aba00599cd05", "AQAAAAEAACcQAAAAECdD2nBXDagIz4owbEl+8DEGmzicK+AqGEIKsK7Z40RUfn0lomxe79Spx4di4fwUrw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserRoles",
                table: "AppUserRoles");

            migrationBuilder.RenameTable(
                name: "AppUserRoles",
                newName: "IdentityUserRole<string>");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IdentityUserRole<string>",
                table: "IdentityUserRole<string>",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "AE59A954-C5F1-419A-A3FF-38A4818EE3A0",
                column: "ConcurrencyStamp",
                value: "d6d656da-b29b-491b-aa35-fc65f51e4f21");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: "40FB70EC-DBE5-46D0-A55A-A63E751E7AD5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5314cb4d-ac33-4601-a8b6-3c1c1b472190", "AQAAAAEAACcQAAAAEIOZGO/sa0fQZ84vQV07k+GwVa/ilJatQ3vh+i+29sim5GqAIWbu1srBWwfU4SuabA==" });
        }
    }
}
