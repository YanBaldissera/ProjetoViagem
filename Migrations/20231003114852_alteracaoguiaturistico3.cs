using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpresaDeViagem.Migrations
{
    /// <inheritdoc />
    public partial class alteracaoguiaturistico3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "GuiaTuristico",
                newName: "DocumentoGuia");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "GuiaTuristico",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "GuiaTuristico");

            migrationBuilder.RenameColumn(
                name: "DocumentoGuia",
                table: "GuiaTuristico",
                newName: "Id");
        }
    }
}
