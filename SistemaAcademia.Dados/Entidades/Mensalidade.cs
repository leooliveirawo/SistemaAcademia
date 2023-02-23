namespace SistemaAcademia.Dados.Entidades
{
    public class Mensalidade
    {
        public long Id { get; set; }
        public long AlunoId { get; set; }
        public DateTime IniciadoEm { get; set; }
        public DateTime TerminaEm { get; set; }

        public Aluno Aluno { get; protected set; } = null!;

        public double DiasRestantes => (TerminaEm - IniciadoEm).TotalDays;

        public bool Venceu => TerminaEm < DateTime.Now.Date;
    }
}
