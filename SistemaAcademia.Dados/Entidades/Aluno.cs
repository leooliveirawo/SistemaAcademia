namespace SistemaAcademia.Dados.Entidades
{
    public class Aluno
    {
        public long Id { get; set; }
        public long PlanoId { get; set; }
        public string NomeCompleto { get; set; } = null!;
        public string CPF { get; set; } = null!;
        public DateTime? DataNascimento { get; set; }
        public string? Logradouro { get; set; }
        public string? Complemento { get; set; }
        public string? CEP { get; set; }
        public string? Bairro { get; set; }
        public string? Cidade { get; set; }
        public string? EstadoUF { get; set; }

        public DateTime DataUltimoTreino { get; set; }

        public Plano Plano { get; protected set; } = null!;
        public ICollection<AlunoTelefone> Telefones { get; set; }

        public ICollection<Treino> Treinos { get; set; }

        public ICollection<Mensalidade> Mensalidades { get; set; }

        public Aluno()
        {
            Telefones = new HashSet<AlunoTelefone>();
            Treinos = new HashSet<Treino>();
            Mensalidades = new HashSet<Mensalidade>();
        }
    }
}
