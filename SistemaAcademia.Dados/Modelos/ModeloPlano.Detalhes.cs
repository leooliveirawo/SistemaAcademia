namespace SistemaAcademia.Dados.Modelos
{
    public partial class ModeloPlano
    {
        public class Detalhes
        {
            public string Descricao { get; set; } = null!;
            public long Dias { get; set; }
            public decimal Valor { get; set; }
            public bool CobradoMensalmente { get; set; }
            public int? MesesCobrados { get; set; }
        }
    }
}
