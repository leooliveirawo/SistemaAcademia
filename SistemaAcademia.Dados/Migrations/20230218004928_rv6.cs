using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaAcademia.Dados.Migrations
{
    /// <inheritdoc />
    public partial class rv6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Treino_Alunos_AlunoId",
                table: "Treino");

            migrationBuilder.DropForeignKey(
                name: "FK_TreinosExercicios_Treino_TreinoId",
                table: "TreinosExercicios");

            migrationBuilder.DropForeignKey(
                name: "FK_TreinosHistoricos_Treino_ProximoTreinoId",
                table: "TreinosHistoricos");

            migrationBuilder.DropForeignKey(
                name: "FK_TreinosHistoricos_Treino_UltimoTreinoId",
                table: "TreinosHistoricos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Treino",
                table: "Treino");

            migrationBuilder.RenameTable(
                name: "Treino",
                newName: "Treinos");

            migrationBuilder.RenameIndex(
                name: "IX_Treino_AlunoId",
                table: "Treinos",
                newName: "IX_Treinos_AlunoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Treinos",
                table: "Treinos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Treinos_Alunos_AlunoId",
                table: "Treinos",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TreinosExercicios_Treinos_TreinoId",
                table: "TreinosExercicios",
                column: "TreinoId",
                principalTable: "Treinos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TreinosHistoricos_Treinos_ProximoTreinoId",
                table: "TreinosHistoricos",
                column: "ProximoTreinoId",
                principalTable: "Treinos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TreinosHistoricos_Treinos_UltimoTreinoId",
                table: "TreinosHistoricos",
                column: "UltimoTreinoId",
                principalTable: "Treinos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Treinos_Alunos_AlunoId",
                table: "Treinos");

            migrationBuilder.DropForeignKey(
                name: "FK_TreinosExercicios_Treinos_TreinoId",
                table: "TreinosExercicios");

            migrationBuilder.DropForeignKey(
                name: "FK_TreinosHistoricos_Treinos_ProximoTreinoId",
                table: "TreinosHistoricos");

            migrationBuilder.DropForeignKey(
                name: "FK_TreinosHistoricos_Treinos_UltimoTreinoId",
                table: "TreinosHistoricos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Treinos",
                table: "Treinos");

            migrationBuilder.RenameTable(
                name: "Treinos",
                newName: "Treino");

            migrationBuilder.RenameIndex(
                name: "IX_Treinos_AlunoId",
                table: "Treino",
                newName: "IX_Treino_AlunoId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Treino",
                table: "Treino",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Treino_Alunos_AlunoId",
                table: "Treino",
                column: "AlunoId",
                principalTable: "Alunos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TreinosExercicios_Treino_TreinoId",
                table: "TreinosExercicios",
                column: "TreinoId",
                principalTable: "Treino",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TreinosHistoricos_Treino_ProximoTreinoId",
                table: "TreinosHistoricos",
                column: "ProximoTreinoId",
                principalTable: "Treino",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TreinosHistoricos_Treino_UltimoTreinoId",
                table: "TreinosHistoricos",
                column: "UltimoTreinoId",
                principalTable: "Treino",
                principalColumn: "Id");
        }
    }
}
