using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto_Adote_Pet.Migrations
{
    public partial class FK0206 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioCpf",
                table: "Pets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Pets_UsuarioCpf",
                table: "Pets",
                column: "UsuarioCpf",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pets_Usuarios_UsuarioCpf",
                table: "Pets",
                column: "UsuarioCpf",
                principalTable: "Usuarios",
                principalColumn: "Cpf",
                onDelete: ReferentialAction.Cascade);
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
