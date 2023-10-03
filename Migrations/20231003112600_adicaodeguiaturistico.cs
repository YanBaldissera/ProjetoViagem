using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpresaDeViagem.Migrations
{
    /// <inheritdoc />
    public partial class adicaodeguiaturistico : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cidades",
                columns: table => new
                {
                    Cidade = table.Column<string>(type: "TEXT", nullable: false),
                    País = table.Column<string>(type: "TEXT", nullable: false),
                    NHabitantes = table.Column<string>(type: "TEXT", nullable: false),
                    Continente = table.Column<string>(type: "TEXT", nullable: false),
                    PTuristico = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cidades", x => x.Cidade);
                });

            migrationBuilder.CreateTable(
                name: "Companhia",
                columns: table => new
                {
                    CNPJ = table.Column<string>(type: "TEXT", nullable: false),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Aviões = table.Column<string>(type: "TEXT", nullable: false),
                    Destinos = table.Column<string>(type: "TEXT", nullable: false),
                    Pacotes = table.Column<string>(type: "TEXT", nullable: false),
                    Seguros = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companhia", x => x.CNPJ);
                });

            migrationBuilder.CreateTable(
                name: "GuiaTuristicos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nome = table.Column<string>(type: "TEXT", nullable: false),
                    Empresa = table.Column<string>(type: "TEXT", nullable: false),
                    Valor = table.Column<decimal>(type: "TEXT", nullable: false),
                    Nota = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuiaTuristicos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paises",
                columns: table => new
                {
                    NomePais = table.Column<string>(type: "TEXT", nullable: false),
                    Continente = table.Column<string>(type: "TEXT", nullable: false),
                    EstacaoAno = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paises", x => x.NomePais);
                });

            migrationBuilder.CreateTable(
                name: "Passagem",
                columns: table => new
                {
                    NVoo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NomePassageiro = table.Column<string>(type: "TEXT", nullable: false),
                    DataEmbarque = table.Column<string>(type: "TEXT", nullable: false),
                    Destino = table.Column<string>(type: "TEXT", nullable: false),
                    LocalEmbarque = table.Column<string>(type: "TEXT", nullable: false),
                    Classe = table.Column<string>(type: "TEXT", nullable: false),
                    NConexoes = table.Column<int>(type: "INTEGER", nullable: false),
                    Assento = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Passagem", x => x.NVoo);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cidades");

            migrationBuilder.DropTable(
                name: "Companhia");

            migrationBuilder.DropTable(
                name: "GuiaTuristicos");

            migrationBuilder.DropTable(
                name: "Paises");

            migrationBuilder.DropTable(
                name: "Passagem");
        }
    }
}
