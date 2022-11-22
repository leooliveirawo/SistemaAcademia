namespace SistemaAcademia.Dados.Entidades
{
    public class TreinoExercicio : Entidade
    {
        public long TreinoId { get; set; }
        public long ExercicioId { get; set; }

        public Treino Treino { get; set; }
        public Exercicio Exercicio { get; set; }
    }
}
