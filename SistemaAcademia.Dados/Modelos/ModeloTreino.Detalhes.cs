using SistemaAcademia.Dados.Valores;

namespace SistemaAcademia.Dados.Modelos
{
    public partial class ModeloTreino
    {
        public class Detalhes
        {
            public class Exercicio
            {
                public long ExercicioId { get; set; }
                public string ExercicioDescricao { get; set; } = null!;
                public long NumeroRepeticoes { get; set; }
                public long NumeroSeries { get; set; }
            }

            public long NumeroAtualTreino { get; set; }
            public long NumeroMaximoTreino { get; set; }
            public DateTime DataTreino { get; set; }
            public bool TreinoAtual { get; set; }
            public TreinoTipo Tipo { get; set; }
            public bool Ativo { get; set; }

            public ICollection<Exercicio> Exercicios { get; set; } = new List<Exercicio>();
        }
    }
}
