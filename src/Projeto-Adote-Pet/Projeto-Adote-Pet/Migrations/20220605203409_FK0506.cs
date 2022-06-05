using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto_Adote_Pet.Migrations
{
    public partial class FK0506 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsuarioCpf",
                table: "Pets",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pets_UsuarioCpf",
                table: "Pets",
                column: "UsuarioCpf",
                unique: true,
                filter: "[UsuarioCpf] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Usuarios_UsuarioCpf",
                table: "Pets",
                column: "UsuarioCpf",
                principalTable: "Usuarios",
                principalColumn: "Cpf",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pets_Usuarios_UsuarioCpf",
                table: "Pets");

            migrationBuilder.DropIndex(
                name: "IX_Pets_UsuarioCpf",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "UsuarioCpf",
                table: "Pets");
        }
    }
}
