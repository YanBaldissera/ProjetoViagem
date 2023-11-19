using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpresaDeViagem.Migrations
{
    /// <inheritdoc />
    public partial class criacaodeCarroDeAluguel5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CarrosAluguel_EmpresasAluguelCarros_EmpresaCNPJ",
                table: "CarrosAluguel");

            migrationBuilder.DropTable(
                name: "EmpresasAluguelCarros");

            migrationBuilder.DropIndex(
                name: "IX_CarrosAluguel_EmpresaCNPJ",
                table: "CarrosAluguel");

            migrationBuilder.DropColumn(
                name: "EmpresaCNPJ",
                table: "CarrosAluguel");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "EmpresaCNPJ",
                table: "CarrosAluguel",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "EmpresasAluguelCarros",
                columns: table => new
                {
                    CNPJ = table.Column<string>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Nota = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpresasAluguelCarros", x => x.CNPJ);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarrosAluguel_EmpresaCNPJ",
                table: "CarrosAluguel",
                column: "EmpresaCNPJ");

            migrationBuilder.AddForeignKey(
                name: "FK_CarrosAluguel_EmpresasAluguelCarros_EmpresaCNPJ",
                table: "CarrosAluguel",
                column: "EmpresaCNPJ",
                principalTable: "EmpresasAluguelCarros",
                principalColumn: "CNPJ",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
