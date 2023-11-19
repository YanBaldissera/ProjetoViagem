using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmpresaDeViagem.Migrations
{
    /// <inheritdoc />
    public partial class AlteradoCliente : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Sobrenome",
                table: "Cliente",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Sobrenome",
                table: "Cliente");
        }
    }
}
