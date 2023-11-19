using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpresaDeViagem.Migrations
{
    /// <inheritdoc />
    public partial class Alteradodata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hospedagem",
                columns: table => new
                {
                    Cnpj = table.Column<string>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Alimentacao = table.Column<string>(type: "TEXT", nullable: false),
                    ValorDiaria = table.Column<float>(type: "REAL", nullable: false),
                    Estrelas = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospedagem", x => x.Cnpj);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hospedagem");
        }
    }
}
