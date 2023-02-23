using SistemaAcademia.Dados.Entidades;
using SistemaAcademia.Dados.Valores;

namespace SistemaAcademia.Dados.Suporte
{
    public static class SuporteDados
    {
        public static IEnumerable<Treino> PreencherTodosTreinoTipo()
        {
            var treinoTipos = Enum.GetValues<TreinoTipo>();

            var treinos = new List<Treino>();

            for (var i = 0; i < treinoTipos.Length; i++)
            {
                treinos.Add(new Treino
                {
                    Tipo = treinoTipos[i],
                    NumeroMaximoTreino = 40,
                    DataTreino = new()
                });
            }

            return treinos;
        }

        public static string ObterNomeTreinoTipo(TreinoTipo tipo)
        {
            switch (tipo)
            {
                case TreinoTipo.TreinoA:
                    return "TREINO A";
                case TreinoTipo.TreinoB:
                    return "TREINO B";
                case TreinoTipo.TreinoC:
                    return "TREINO C";
                case TreinoTipo.TreinoD:
                    return "TREINO D";
                case TreinoTipo.TreinoE:
                    return "TREINO E";
                case TreinoTipo.TreinoF:
                    return "TREINO F";
                default:
                    throw new NotImplementedException();
            }
        }

        public static string ObterNomeFormasPagamentos(FormasPagamentos formaPagamento)
        {
            switch (formaPagamento)
            {
                case FormasPagamentos.Dinheiro:
                    return "DINHEIRO";
                case FormasPagamentos.CartaoDebito:
                    return "CARTÃO DE DÉBITO";
                case FormasPagamentos.CartaoCredito:
                    return "CARTÃO DE CRÉDITO";
                default:
                    throw new NotImplementedException();
            }
        }

    }
}
