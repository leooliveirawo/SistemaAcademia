using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaAcademia.Dados.Migrations
{
    /// <inheritdoc />
    public partial class rv16 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProximoTreino",
                table: "Treinos");

            migrationBuilder.DropColumn(
                name: "UltimoTreino",
                table: "Treinos");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ProximoTreino",
                table: "Treinos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UltimoTreino",
                table: "Treinos",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
