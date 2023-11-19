using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpresaDeViagem.Migrations
{
    /// <inheritdoc />
    public partial class criacaodeCarroDeAluguel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmpresasAluguelCarros",
                columns: table => new
                {
                    CNPJ = table.Column<string>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    ValorDiaria = table.Column<decimal>(type: "TEXT", nullable: false),
                    Nota = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresasAluguelCarros", x => x.CNPJ);
                });

            migrationBuilder.CreateTable(
                name: "CarrosAluguel",
                columns: table => new
                {
                    Placa = table.Column<string>(type: "TEXT", nullable: false),
                    Modelo = table.Column<string>(type: "TEXT", nullable: false),
                    Marca = table.Column<string>(type: "TEXT", nullable: false),
                    ValorDiaria = table.Column<decimal>(type: "TEXT", nullable: false),
                    EmpresaCNPJ = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrosAluguel", x => x.Placa);
                    table.ForeignKey(
                        name: "FK_CarrosAluguel_EmpresasAluguelCarros_EmpresaCNPJ",
                        column: x => x.EmpresaCNPJ,
                        principalTable: "EmpresasAluguelCarros",
                        principalColumn: "CNPJ",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarrosAluguel_EmpresaCNPJ",
                table: "CarrosAluguel",
                column: "EmpresaCNPJ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarrosAluguel");

            migrationBuilder.DropTable(
                name: "EmpresasAluguelCarros");
        }
    }
}
