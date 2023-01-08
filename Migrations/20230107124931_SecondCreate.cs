using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication6.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarID",
                table: "Client",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "autovehiculId",
                table: "Client",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Autovehicul",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Autovehicul", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Client_autovehiculId",
                table: "Client",
                column: "autovehiculId");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Autovehicul_autovehiculId",
                table: "Client",
                column: "autovehiculId",
                principalTable: "Autovehicul",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Autovehicul_autovehiculId",
                table: "Client");

            migrationBuilder.DropTable(
                name: "Autovehicul");

            migrationBuilder.DropIndex(
                name: "IX_Client_autovehiculId",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "CarID",
                table: "Client");

            migrationBuilder.DropColumn(
                name: "autovehiculId",
                table: "Client");
        }
    }
}
