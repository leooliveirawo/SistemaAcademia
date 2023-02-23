using SistemaAcademia.Dados.Valores;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaAcademia.Dados.Entidades
{
    public class AlunoTelefone
    {
        public long Id { get; set; }
        public long AlunoId { get; set; }
        public TelefoneTipo Tipo { get; set; } = TelefoneTipo.TelefonePessoal;
        public string DDD { get; set; } = null!;

        public string Numero { get; set; } = null!;
        public bool PossuiWhatsApp { get; set; }

        public Aluno Aluno { get; protected set; } = null!;
    }
}
