using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication6.Migrations
{
    public partial class ThirdCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CarName",
                table: "Autovehicul",
                newName: "Problema");

            migrationBuilder.AddColumn<int>(
                name: "An",
                table: "Autovehicul",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Marca",
                table: "Autovehicul",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Autovehicul",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "An",
                table: "Autovehicul");

            migrationBuilder.DropColumn(
                name: "Marca",
                table: "Autovehicul");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Autovehicul");

            migrationBuilder.RenameColumn(
                name: "Problema",
                table: "Autovehicul",
                newName: "CarName");
        }
    }
}
