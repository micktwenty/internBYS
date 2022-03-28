using Microsoft.EntityFrameworkCore.Migrations;

namespace Complains_System.Migrations
{
    public partial class updateappuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers");

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "AE59A954-C5F1-419A-A3FF-38A4818EE3A0", "40FB70EC-DBE5-46D0-A55A-A63E751E7AD5" });


            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AppUsers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers",
                column: "UserName");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "AE59A954-C5F1-419A-A3FF-38A4818EE3A0",
                column: "ConcurrencyStamp",
                value: "2a8486a7-aaec-43f5-910b-6eee34b29911");



            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "UserName",
                keyValue: "admin",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "idteacher" },
                values: new object[] { "311892ca-986a-4300-b066-e931dae8c360", "AQAAAAEAACcQAAAAEISEbuyITPXSOuCU4FSp7E59waPFEr7mXLE26NJIk1EXU4te08E1AUlkvzGGAgEGqg==", 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers");

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "AE59A954-C5F1-419A-A3FF-38A4818EE3A0", "admin" });

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AppUserRoles");

            migrationBuilder.AlterColumn<int>(
                name: "idteacher",
                table: "AppUsers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "AppUsers",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "AppUsers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUsers",
                table: "AppUsers",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: "AE59A954-C5F1-419A-A3FF-38A4818EE3A0",
                column: "ConcurrencyStamp",
                value: "fcd1517d-421d-4085-ab34-90a5778190f2");

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "AE59A954-C5F1-419A-A3FF-38A4818EE3A0", "40FB70EC-DBE5-46D0-A55A-A63E751E7AD5" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: "40FB70EC-DBE5-46D0-A55A-A63E751E7AD5",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "idteacher" },
                values: new object[] { "8165f4b5-6f40-468d-80fb-aba00599cd05", "AQAAAAEAACcQAAAAECdD2nBXDagIz4owbEl+8DEGmzicK+AqGEIKsK7Z40RUfn0lomxe79Spx4di4fwUrw==", null });
        }
    }
}
