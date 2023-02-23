using SistemaAcademia.Dados.Valores;

namespace SistemaAcademia.Dados.Entidades
{
    public class Treino
    {
        public long Id { get; set; }
        public long AlunoId { get; set; }
        public TreinoTipo Tipo { get; set; }
        public long NumeroMaximoTreino { get; set; }
        public long NumeroAtualTreino { get; set; }
        public bool Ativo { get; set; } = true;

        public bool TreinoAtual { get; set; }
        public DateTime DataTreino { get; set; }

        public Aluno Aluno { get; protected set; } = null!;

        public ICollection<TreinoExercicio> Exercicios { get; set; }

        public Treino()
        {
            Tipo = TreinoTipo.TreinoA;

            Exercicios = new HashSet<TreinoExercicio>();
        }
    }
}
