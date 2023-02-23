namespace SistemaAcademia.Dados.Entidades
{
    public class Exercicio
    {
        public long Id { get; set; }
        public string Descricao { get; set; } = null!;

        public ICollection<TreinoExercicio> Treinos { get; protected set; }

        public Exercicio()
        {
            Treinos = new HashSet<TreinoExercicio>();
        }
    }
}
