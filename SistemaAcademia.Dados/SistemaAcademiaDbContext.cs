using Microsoft.EntityFrameworkCore;
using SistemaAcademia.Dados.Entidades;

namespace SistemaAcademia.Dados
{
    public class SistemaAcademiaDbContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Plano> Planos { get; set; }
        public DbSet<Exercicio> Exercicios { get; set; }
        public DbSet<TreinoExercicio> TreinosExercicios { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Treino> Treinos { get; set; }
        public DbSet<TreinoExercicio> TreinosExercicios { get; set; }
    }
}
