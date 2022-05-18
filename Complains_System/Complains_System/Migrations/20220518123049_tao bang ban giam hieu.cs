using Microsoft.EntityFrameworkCore.Migrations;

namespace Complains_System.Migrations
{
    public partial class taobangbangiamhieu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Board_of_directorss",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(225)", maxLength: 225, nullable: true),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    phone = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Board_of_directorss", x => x.id);
                });

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
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "979e4e40-53dd-4fd1-aaef-8b70dc041da1", "board_of_director" });

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "AE59A954-C5F1-419A-A3FF-38A4818EE3A0",
                column: "ConcurrencyStamp",
                value: "881c7b99-c6bf-4dfa-93a9-08efc7bf3b15");

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId", "Discriminator" },
                values: new object[] { "A639AE1A-D634-455C-BC58-E68883695BE2", "D7109CE2-34E7-4736-9687-4418A3973285", "AppUserRole" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "UserName",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4cf43314-dd2c-4b96-bea7-20e798c7faa6", "AQAAAAEAACcQAAAAECk5sueWtsKSFlAHbt2jB1nflHQ1E6uv24hq/0NIihzObHJtUY0rcSAM5iptEBQEaw==" });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "UserName", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "Id", "IdDepartment", "IdStudent", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "Roles", "SecurityStamp", "TwoFactorEnabled", "idteacher" },
                values: new object[] { "ngmanhtoan@due.udn.vn", 0, "1653f688-ae40-4435-99e4-19784f464b31", "ngmanhtoan@due.udn.vn", true, "D7109CE2-34E7-4736-9687-4418A3973285", 0, null, false, null, "Nguyễn Mạnh Toàn", "ngmanhtoan@due.udn.vn", "Toan", "AQAAAAEAACcQAAAAEDGNHnF5Gd2/wiVmZQ50dBipAR08U3u5feboW9ybeaKeR1C9IEInJYmXebp/Rd+Unw==", null, false, null, "", false, 0 });

            migrationBuilder.InsertData(
                table: "Board_of_directorss",
                columns: new[] { "id", "Email", "name", "phone" },
                values: new object[] { 1, "ngmanhtoan@due.udn.vn", "Nguyễn Mạnh Toàn", "0978456112" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Board_of_directorss");

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "A639AE1A-D634-455C-BC58-E68883695BE2", "D7109CE2-34E7-4736-9687-4418A3973285" });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "UserName",
                keyValue: "ngmanhtoan@due.udn.vn");

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
                columns: new[] { "ConcurrencyStamp", "Name" },
                values: new object[] { "58d3b646-c435-4b9f-8e1c-ba3d3fa20d4d", "complain_department" });

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
        }
    }
}
