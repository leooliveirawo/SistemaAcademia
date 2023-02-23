using Microsoft.EntityFrameworkCore;

using SistemaAcademia.Dados.Entidades;

namespace SistemaAcademia.Dados
{
    public class SistemaAcademiaDbContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; protected set; } = null!;
        public DbSet<AlunoTelefone> AlunosTelefones { get; protected set; } = null!;
        public DbSet<Exercicio> Exercicios { get; protected set; } = null!;
        public DbSet<Treino> Treinos { get; protected set; } = null!;
        public DbSet<TreinoExercicio> TreinosExercicios { get; protected set; } = null!;
        public DbSet<Plano> Planos { get; protected set; } = null!;
        public DbSet<Mensalidade> Mensalidades { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=SistemaAcademia;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Aluno>()
                .Property(x => x.DataNascimento)
                .HasColumnType("DATE");

            modelBuilder.Entity<Treino>()
                .Property(x => x.Tipo);

            modelBuilder.Entity<Mensalidade>()
                .Property(x => x.IniciadoEm)
                .HasColumnType("DATE");

            modelBuilder.Entity<Mensalidade>()
                .Property(x => x.TerminaEm)
                .HasColumnType("DATE");
        }
    }
}
