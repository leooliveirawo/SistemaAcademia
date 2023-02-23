using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SistemaAcademia.Dados.Migrations
{
    /// <inheritdoc />
    public partial class rv2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreinoExercicios_Exercicios_ExercicioId",
                table: "TreinoExercicios");

            migrationBuilder.DropForeignKey(
                name: "FK_TreinoExercicios_Treino_TreinoId",
                table: "TreinoExercicios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TreinoExercicios",
                table: "TreinoExercicios");

            migrationBuilder.RenameTable(
                name: "TreinoExercicios",
                newName: "TreinosExercicios");

            migrationBuilder.RenameIndex(
                name: "IX_TreinoExercicios_TreinoId",
                table: "TreinosExercicios",
                newName: "IX_TreinosExercicios_TreinoId");

            migrationBuilder.RenameIndex(
                name: "IX_TreinoExercicios_ExercicioId",
                table: "TreinosExercicios",
                newName: "IX_TreinosExercicios_ExercicioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TreinosExercicios",
                table: "TreinosExercicios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TreinosExercicios_Exercicios_ExercicioId",
                table: "TreinosExercicios",
                column: "ExercicioId",
                principalTable: "Exercicios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TreinosExercicios_Treino_TreinoId",
                table: "TreinosExercicios",
                column: "TreinoId",
                principalTable: "Treino",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreinosExercicios_Exercicios_ExercicioId",
                table: "TreinosExercicios");

            migrationBuilder.DropForeignKey(
                name: "FK_TreinosExercicios_Treino_TreinoId",
                table: "TreinosExercicios");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TreinosExercicios",
                table: "TreinosExercicios");

            migrationBuilder.RenameTable(
                name: "TreinosExercicios",
                newName: "TreinoExercicios");

            migrationBuilder.RenameIndex(
                name: "IX_TreinosExercicios_TreinoId",
                table: "TreinoExercicios",
                newName: "IX_TreinoExercicios_TreinoId");

            migrationBuilder.RenameIndex(
                name: "IX_TreinosExercicios_ExercicioId",
                table: "TreinoExercicios",
                newName: "IX_TreinoExercicios_ExercicioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TreinoExercicios",
                table: "TreinoExercicios",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TreinoExercicios_Exercicios_ExercicioId",
                table: "TreinoExercicios",
                column: "ExercicioId",
                principalTable: "Exercicios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TreinoExercicios_Treino_TreinoId",
                table: "TreinoExercicios",
                column: "TreinoId",
                principalTable: "Treino",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
