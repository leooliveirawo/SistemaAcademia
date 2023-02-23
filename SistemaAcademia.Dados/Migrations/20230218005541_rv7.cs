using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaAcademia.Dados.Migrations
{
    /// <inheritdoc />
    public partial class rv7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Data",
                table: "TreinosHistoricos",
                newName: "DataTreino");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DataTreino",
                table: "TreinosHistoricos",
                newName: "Data");
        }
    }
}
