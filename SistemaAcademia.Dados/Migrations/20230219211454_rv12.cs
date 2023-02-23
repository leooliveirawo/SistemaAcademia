using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaAcademia.Dados.Migrations
{
    /// <inheritdoc />
    public partial class rv12 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TreinosHistoricos");

            migrationBuilder.AddColumn<bool>(
                name: "Ativo",
                table: "Treinos",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ativo",
                table: "Treinos");

            migrationBuilder.DropColumn(
                name: "ProximoTreino",
                table: "Treinos");

            migrationBuilder.DropColumn(
                name: "UltimoTreino",
                table: "Treinos");

            migrationBuilder.CreateTable(
                name: "TreinosHistoricos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlunoId = table.Column<long>(type: "bigint", nullable: false),
                    ProximoTreinoId = table.Column<long>(type: "bigint", nullable: false),
                    UltimoTreinoId = table.Column<long>(type: "bigint", nullable: false),
                    DataTreino = table.Column<DateTime>(type: "DATE", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TreinosHistoricos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TreinosHistoricos_Alunos_AlunoId",
                        column: x => x.AlunoId,
                        principalTable: "Alunos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TreinosHistoricos_Treinos_ProximoTreinoId",
                        column: x => x.ProximoTreinoId,
                        principalTable: "Treinos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TreinosHistoricos_Treinos_UltimoTreinoId",
                        column: x => x.UltimoTreinoId,
                        principalTable: "Treinos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TreinosHistoricos_AlunoId",
                table: "TreinosHistoricos",
                column: "AlunoId");

            migrationBuilder.CreateIndex(
                name: "IX_TreinosHistoricos_ProximoTreinoId",
                table: "TreinosHistoricos",
                column: "ProximoTreinoId");

            migrationBuilder.CreateIndex(
                name: "IX_TreinosHistoricos_UltimoTreinoId",
                table: "TreinosHistoricos",
                column: "UltimoTreinoId");
        }
    }
}
