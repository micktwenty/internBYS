using Microsoft.EntityFrameworkCore.Migrations;

namespace Complains_System.Migrations
{
    public partial class updatekhoangôai : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            migrationBuilder.AddColumn<string>(
              name: "username",
              table: "AppUserRoles",
              type: "nvarchar(450)",
              nullable: false);


            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "6BFD2AC2-5F05-4EA7-87D9-ECF95EE4A1D5",
                column: "ConcurrencyStamp",
                value: "dc85e6c5-692e-40d6-b85b-c3efc6e837e0");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "8E742903-5250-4C2C-829B-F1BAE8E7981B",
                column: "ConcurrencyStamp",
                value: "22b34993-d96f-41f5-b36f-32c91d5cc5c7");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "A639AE1A-D634-455C-BC58-E68883695BE2",
                column: "ConcurrencyStamp",
                value: "6861c52a-c7c7-4884-89a4-502fa9c9fb8a");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "AE59A954-C5F1-419A-A3FF-38A4818EE3A0",
                column: "ConcurrencyStamp",
                value: "0616c328-83d6-49cd-9644-9c9ff234375f");

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "AE59A954-C5F1-419A-A3FF-38A4818EE3A0", "40FB70EC-DBE5-46D0-A55A-A63E751E7AD5" },
                column: "Username",
                value: "admin");


            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "UserName",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ab0f2b29-2f47-49e2-833d-23835c464ef0", "AQAAAAEAACcQAAAAEEbEU9a+FSmhYP2Vk+SvDKVitKjBt0rGvW2JZNp24cBSS61cnzWs9tiMUzU+J86Xyg==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "UserName",
                keyValue: "ngmanhtoan@due.udn.vn",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d6c91369-53ab-4ed1-bf8b-659022fb6d36", "AQAAAAEAACcQAAAAEApSRa6T4etiXZ36QMPVSAnVve+BEm8eAMGqh1LmH4Ee9xaohhtWVUBUqr4yZb0OqA==" });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserRoles_RoleId",
                table: "AppUserRoles",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserRoles_AppRoles_RoleId",
                table: "AppUserRoles",
                column: "RoleId",
                principalTable: "AppRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserRoles_AppUsers_Username",
                table: "AppUserRoles",
                column: "Username",
                principalTable: "AppUsers",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUserRoles_AppRoles_RoleId",
                table: "AppUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUserRoles_AppUsers_Username",
                table: "AppUserRoles");

            migrationBuilder.DropIndex(
                name: "IX_AppUserRoles_RoleId",
                table: "AppUserRoles");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "AppUserRoles",
                newName: "AppUserUserName");

            migrationBuilder.RenameIndex(
                name: "IX_AppUserRoles_Username",
                table: "AppUserRoles",
                newName: "IX_AppUserRoles_AppUserUserName");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "6BFD2AC2-5F05-4EA7-87D9-ECF95EE4A1D5",
                column: "ConcurrencyStamp",
                value: "3ddfe6c0-39cb-48b3-9772-1014b1264a21");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "8E742903-5250-4C2C-829B-F1BAE8E7981B",
                column: "ConcurrencyStamp",
                value: "2f31e935-f0f5-41d4-9f6e-0283d25208c9");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "A639AE1A-D634-455C-BC58-E68883695BE2",
                column: "ConcurrencyStamp",
                value: "979e4e40-53dd-4fd1-aaef-8b70dc041da1");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "AE59A954-C5F1-419A-A3FF-38A4818EE3A0",
                column: "ConcurrencyStamp",
                value: "881c7b99-c6bf-4dfa-93a9-08efc7bf3b15");

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "AE59A954-C5F1-419A-A3FF-38A4818EE3A0", "40FB70EC-DBE5-46D0-A55A-A63E751E7AD5" },
                column: "AppUserUserName",
                value: null);

            migrationBuilder.UpdateData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "A639AE1A-D634-455C-BC58-E68883695BE2", "D7109CE2-34E7-4736-9687-4418A3973285" },
                column: "AppUserUserName",
                value: null);

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "UserName",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4cf43314-dd2c-4b96-bea7-20e798c7faa6", "AQAAAAEAACcQAAAAECk5sueWtsKSFlAHbt2jB1nflHQ1E6uv24hq/0NIihzObHJtUY0rcSAM5iptEBQEaw==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "UserName",
                keyValue: "ngmanhtoan@due.udn.vn",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1653f688-ae40-4435-99e4-19784f464b31", "AQAAAAEAACcQAAAAEDGNHnF5Gd2/wiVmZQ50dBipAR08U3u5feboW9ybeaKeR1C9IEInJYmXebp/Rd+Unw==" });

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserRoles_AppUsers_AppUserUserName",
                table: "AppUserRoles",
                column: "AppUserUserName",
                principalTable: "AppUsers",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
