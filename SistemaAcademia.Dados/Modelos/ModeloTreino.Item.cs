using SistemaAcademia.Dados.Valores;

namespace SistemaAcademia.Dados.Modelos
{
    public partial class ModeloTreino
    {
        public class Item
        {
            public long Id { get; set; }
            public string Descricao { get; set; } = null!;
            public TreinoTipo Tipo { get; set; }
        }
    }
}
