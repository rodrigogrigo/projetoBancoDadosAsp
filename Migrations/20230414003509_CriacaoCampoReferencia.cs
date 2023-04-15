using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PrimeiroProjetoBanco.Migrations
{
    /// <inheritdoc />
    public partial class CriacaoCampoReferencia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "referencia",
                table: "Pessoa",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "referencia",
                table: "Pessoa");
        }
    }
}
