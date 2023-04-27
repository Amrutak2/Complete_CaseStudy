using Microsoft.EntityFrameworkCore.Migrations;

namespace RollOff_Test4API.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_login",
                table: "login");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "login",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "login",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_login",
                table: "login",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_login",
                table: "login");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "login");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "login",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_login",
                table: "login",
                column: "Username");
        }
    }
}
