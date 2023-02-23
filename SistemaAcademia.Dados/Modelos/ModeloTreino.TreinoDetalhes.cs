using SistemaAcademia.Dados.Valores;

namespace SistemaAcademia.Dados.Modelos
{
    public partial class ModeloTreino
    {
        public class TreinoDetalhes
        {
            public class Exercicio
            {
                public string ExercicioDescricao { get; set; } = null!;
                public long NumeroRepeticoes { get; set; }
                public long NumeroSeries { get; set; }
            }

            public string NomeCompleto { get; set; } = null!;
            public long NumeroAtualTreino { get; set; }
            public long NumeroMaximoTreino { get; set; }
            public TreinoTipo Tipo { get; set; }
            public bool Ativo { get; set; }

            public ICollection<Exercicio> Exercicios { get; set; } = new List<Exercicio>();
        }
    }
}
