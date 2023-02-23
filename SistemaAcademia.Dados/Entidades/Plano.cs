namespace SistemaAcademia.Dados.Entidades
{
    public class Plano
    {
        public long Id { get; set; }
        public string Descricao { get; set; } = null!;
        public long Dias { get; set; }
        public decimal Valor { get; set; }
        public bool CobradoMensalmente { get; set; }
        public int? MesesCobrados { get; set; }

        public IReadOnlyCollection<Aluno> Alunos { get; protected set; }

        public Plano()
        {
            Alunos = new HashSet<Aluno>();
        }
    }
}
