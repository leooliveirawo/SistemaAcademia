using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademia.Dados.Modelos
{
    public partial class ModeloPlano
    {
        public class Item
        {
            public long Id { get; set; }
            public string Descricao { get; set; } = null!;
        }

    }
}
