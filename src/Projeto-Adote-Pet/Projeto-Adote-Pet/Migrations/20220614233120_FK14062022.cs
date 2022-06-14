using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto_Adote_Pet.Migrations
{
    public partial class FK14062022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pets_UsuarioCpf",
                table: "Pets");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Pets_UsuarioCpf",
                table: "Pets",
                column: "UsuarioCpf");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Pets_UsuarioCpf",
                table: "Pets");

            migrationBuilder.AlterColumn<string>(
                name: "Descricao",
                table: "Pets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pets_UsuarioCpf",
                table: "Pets",
                column: "UsuarioCpf",
                unique: true,
                filter: "[UsuarioCpf] IS NOT NULL");
        }
    }
}
