using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto_Adote_Pet.Migrations
{
    public partial class Proj0106b : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Cidade",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Estado",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Usuarios",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ImagePet",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UsuarioCpf",
                table: "Pets",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pets_UsuarioCpf",
                table: "Pets",
                column: "UsuarioCpf");

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
                name: "Cidade",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "IdUser",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "ImagePet",
                table: "Pets");

            migrationBuilder.DropColumn(
                name: "UsuarioCpf",
                table: "Pets");
        }
    }
}
