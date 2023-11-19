using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpresaDeViagem.Migrations
{
    /// <inheritdoc />
    public partial class criacaodeCarroDeAluguel2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Disponivel",
                table: "CarrosAluguel",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Disponivel",
                table: "CarrosAluguel");
        }
    }
}
