namespace SistemaAcademia.Dados.Entidades
{
    public class Treino : Entidade
    {
        public int AlunoId { get; set; }
        public string Classificacao { get; set; }

        public Aluno Aluno { get; set; }

        public ICollection<TreinoExercicio> TreinosExercicios { get; set; }

        public Treino()
        {
            TreinosExercicios = new HashSet<TreinoExercicio>();
        }
    }
}
