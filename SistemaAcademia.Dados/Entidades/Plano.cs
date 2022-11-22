namespace SistemaAcademia.Dados.Entidades
{
    public class Plano : Entidade
    {
        public string Nome { get; set; }
        public int DiasValidos { get; set; }
        public decimal Valor { get; set; }
        public int NumeroParcelas { get; set; }

        public ICollection<Aluno> Alunos { get; set; }
        public ICollection<Pagamento> Pagamentos { get; set; }

        public Plano()
        {
            Alunos = new List<Aluno>();
            Pagamentos = new HashSet<Pagamento>();
        }
    }
}
