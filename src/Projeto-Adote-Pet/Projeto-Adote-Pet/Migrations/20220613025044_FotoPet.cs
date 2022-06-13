using Microsoft.EntityFrameworkCore.Migrations;

namespace Projeto_Adote_Pet.Migrations
{
    public partial class FotoPet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagePet",
                table: "Pets",
                newName: "Foto");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Foto",
                table: "Pets",
                newName: "ImagePet");
        }
    }
}
