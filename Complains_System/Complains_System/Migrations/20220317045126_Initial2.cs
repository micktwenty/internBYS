using Microsoft.EntityFrameworkCore.Migrations;

namespace Complains_System.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_complains_Employees_employee_reply",
                table: "complains");

            migrationBuilder.AlterColumn<int>(
                name: "employee_reply",
                table: "complains",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_complains_Employees_employee_reply",
                table: "complains",
                column: "employee_reply",
                principalTable: "Employees",
                principalColumn: "id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_complains_Employees_employee_reply",
                table: "complains");

            migrationBuilder.AlterColumn<int>(
                name: "employee_reply",
                table: "complains",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_complains_Employees_employee_reply",
                table: "complains",
                column: "employee_reply",
                principalTable: "Employees",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
