using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto_Adote_Pet.Migrations
{
    public partial class FK0206 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pets_UsuarioCpf",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Usuarios");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_UsuarioCpf",
                table: "Pets",
                column: "UsuarioCpf",
                unique: true,
                filter: "[UsuarioCpf] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pets_UsuarioCpf",
                table: "Pets");

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pets_UsuarioCpf",
                table: "Pets",
                column: "UsuarioCpf");
        }
    }
}
