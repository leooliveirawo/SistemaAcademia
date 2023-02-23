using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademia.Dados.Entidades
{
    public class TreinoExercicio
    {
        public long Id { get; set; }
        public long TreinoId { get; set; }
        public long ExercicioId { get; set; }
        public long NumeroSeries { get; set; }
        public long NumeroRepeticoes { get; set; }

        public Treino Treino { get; protected set; } = null!;
        public Exercicio Exercicio { get; protected set; } = null!;
    }
}
