using SistemaAcademia.Dados.Entidades;
using SistemaAcademia.Dados.Valores;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademia.Dados.Modelos
{
    public partial class ModeloAluno
    {
        public class TreinoDetalhes
        {
            public class Treino
            {
                public class Exercicio
                {
                    public string ExercicioDescricao { get; set; } = null!;
                    public long NumeroRepeticoes { get; set; }
                    public long NumeroSeries { get; set; }
                }

                public TreinoTipo Tipo { get; set; }
                public long NumeroAtualTreino { get; set; }
                public long NumeroMaximoTreino { get; set; }
                public bool Ativo { get; set; }
                public DateTime DataTreino { get; set; }
                public bool TreinoAtual { get; set; }

                public ICollection<Exercicio> Exercicios { get; set; } = null!;
            }

            public string NomeCompleto { get; set; } = null!;
            public DateTime? DataUltimoTreino { get; set; }

            public ICollection<Treino> Treinos { get; set; } = null!;
        }
    }
}
