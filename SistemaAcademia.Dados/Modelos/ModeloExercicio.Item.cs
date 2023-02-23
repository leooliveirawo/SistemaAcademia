namespace SistemaAcademia.Dados.Modelos
{
    public partial class ModeloExercicio
    {
        public class Item
        {
            public long Id { get; set; }
            public string Descricao { get; set; } = null!;
        }
    }
}
