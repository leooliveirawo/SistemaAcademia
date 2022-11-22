namespace SistemaAcademia.Dados.Entidades
{
    public class Exercicio : Entidade
    {
        public string Nome { get; set; }

        public ICollection<TreinoExercicio> TreinosExercicios { get; set; }

        public Exercicio()
        {
            TreinosExercicios = new HashSet<TreinoExercicio>();
        }
    }
}
