namespace SistemaAcademia.Dados.Entidades
{
    public class Aluno : Entidade
    {
        public string NomeCompleto { get; set; }
        public string Cpf { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Referencia { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string EstadoUf { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Telefone3 { get; set; }
        public string Email { get; set; }
    }
}
