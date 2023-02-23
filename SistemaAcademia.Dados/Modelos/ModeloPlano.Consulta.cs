namespace SistemaAcademia.Dados.Modelos
{
    public partial class ModeloPlano
    {
        public class Consulta
        {
            public long Id { get; set; }
            public string Descricao { get; set; } = null!;
            public decimal Valor { get; set; }
        }
    }
}
