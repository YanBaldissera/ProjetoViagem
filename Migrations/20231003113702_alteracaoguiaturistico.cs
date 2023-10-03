using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpresaDeViagem.Migrations
{
    /// <inheritdoc />
    public partial class alteracaoguiaturistico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GuiaTuristicos",
                table: "GuiaTuristicos");

            migrationBuilder.RenameTable(
                name: "GuiaTuristicos",
                newName: "GuiaTuristico");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GuiaTuristico",
                table: "GuiaTuristico",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_GuiaTuristico",
                table: "GuiaTuristico");

            migrationBuilder.RenameTable(
                name: "GuiaTuristico",
                newName: "GuiaTuristicos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GuiaTuristicos",
                table: "GuiaTuristicos",
                column: "Id");
        }
    }
}
