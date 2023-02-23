using SistemaAcademia.Dados.Entidades;
using SistemaAcademia.Dados.Valores;

namespace SistemaAcademia.Dados.Modelos
{
    public partial class ModeloAluno 
    {
        public partial class Detalhes
        {
            public class Telefone
            {
                public TelefoneTipo Tipo { get; set; }
                public string DDD { get; set; } = null!;
                public string Numero { get; set; } = null!;
                public bool PossuiWhatsApp { get; set; }
            }

            public long PlanoId { get; set; }
            public string NomeCompleto { get; set; } = null!;
            public string CPF { get; set; } = null!;
            public DateTime? DataNascimento { get; set; }
            public string? Logradouro { get; set; } = null!;
            public string? Complemento { get; set; } = null!;
            public string? CEP { get; set; } = null!;
            public string? Bairro { get; set; } = null!;
            public string? Cidade { get; set; } = null!;
            public string? EstadoUF { get; set; } = null!;

            public ICollection<Telefone> Telefones { get; set; } = new List<Telefone>();
        }
    }
}
