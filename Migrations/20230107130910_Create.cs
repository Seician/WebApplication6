using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication6.Migrations
{
    public partial class Create : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Autovehicul_autovehiculId",
                table: "Client");

            migrationBuilder.RenameColumn(
                name: "autovehiculId",
                table: "Client",
                newName: "AutovehiculId");

            migrationBuilder.RenameIndex(
                name: "IX_Client_autovehiculId",
                table: "Client",
                newName: "IX_Client_AutovehiculId");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Autovehicul_AutovehiculId",
                table: "Client",
                column: "AutovehiculId",
                principalTable: "Autovehicul",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Client_Autovehicul_AutovehiculId",
                table: "Client");

            migrationBuilder.RenameColumn(
                name: "AutovehiculId",
                table: "Client",
                newName: "autovehiculId");

            migrationBuilder.RenameIndex(
                name: "IX_Client_AutovehiculId",
                table: "Client",
                newName: "IX_Client_autovehiculId");

            migrationBuilder.AddForeignKey(
                name: "FK_Client_Autovehicul_autovehiculId",
                table: "Client",
                column: "autovehiculId",
                principalTable: "Autovehicul",
                principalColumn: "Id");
        }
    }
}
