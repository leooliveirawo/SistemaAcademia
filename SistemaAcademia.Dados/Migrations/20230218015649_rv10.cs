using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaAcademia.Dados.Migrations
{
    /// <inheritdoc />
    public partial class rv10 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PermiteParcelamento",
                table: "Planos",
                newName: "CobradoMensalmente");

            migrationBuilder.RenameColumn(
                name: "MesesMaximoParcelamento",
                table: "Planos",
                newName: "MesesCobrados");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MesesCobrados",
                table: "Planos",
                newName: "MesesMaximoParcelamento");

            migrationBuilder.RenameColumn(
                name: "CobradoMensalmente",
                table: "Planos",
                newName: "PermiteParcelamento");
        }
    }
}
