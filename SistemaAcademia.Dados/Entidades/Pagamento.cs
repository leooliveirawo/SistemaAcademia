namespace SistemaAcademia.Dados.Entidades
{
    public class Pagamento : Entidade
    {
        public long AlunoId { get; set; }
        public long PlanoId { get; set; }

        public DateTime PagoEm { get; set; }
        public DateTime TerminaEm { get; set; }

        public Aluno Aluno { get; set; }
        public Plano Plano { get; set; }
    }
}
