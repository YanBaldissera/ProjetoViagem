using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpresaDeViagem.Migrations
{
    /// <inheritdoc />
    public partial class criacaodeCarroDeAluguel4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ValorDiaria",
                table: "EmpresasAluguelCarros");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "ValorDiaria",
                table: "EmpresasAluguelCarros",
                type: "TEXT",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
