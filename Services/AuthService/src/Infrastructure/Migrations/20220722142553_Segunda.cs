using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    public partial class Segunda : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AuthData_UsuarioProfileId",
                schema: "dbo",
                table: "AuthData",
                column: "UsuarioProfileId",
                unique: true,
                filter: "[UsuarioProfileId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AuthData_UsuarioProfile_UsuarioProfileId",
                schema: "dbo",
                table: "AuthData",
                column: "UsuarioProfileId",
                principalSchema: "dbo",
                principalTable: "UsuarioProfile",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AuthData_UsuarioProfile_UsuarioProfileId",
                schema: "dbo",
                table: "AuthData");

            migrationBuilder.DropIndex(
                name: "IX_AuthData_UsuarioProfileId",
                schema: "dbo",
                table: "AuthData");
        }
    }
}
