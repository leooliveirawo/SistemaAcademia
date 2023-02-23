using SistemaAcademia.Dados.Modelos;
using SistemaAcademia.Dados.Servicos;
using SistemaAcademia.Dados.Suporte;
using SistemaAcademia.Dados.Valores;

namespace SistemaAcademia.App.Suporte
{
    public static class ComboBoxSuporte
    {
        public static void VincularListaPlanos(this ComboBox cbbx, ServicoPlanos servico)
        {
            var id = default(long?);

            if (cbbx.SelectedValue is not null)
                id = (long)cbbx.SelectedValue;

            cbbx.DataSource = default;

            cbbx.ValueMember = nameof(ModeloPlano.Item.Id);
            cbbx.DisplayMember = nameof(ModeloPlano.Item.Descricao);

            cbbx.DataSource = servico.CriarLista();

            if (id is not null)
            {
                cbbx.SelectedValue = id;

                if (cbbx.SelectedValue is null
                    && cbbx.Items.Count > 0)
                    cbbx.SelectedIndex = 0;
            }

        }

        public static void VincularListaExercicios(this ComboBox cbbx, ServicoExercicios servico)
        {
            var id = default(long?);

            if (cbbx.SelectedValue is not null)
                id = (long)cbbx.SelectedValue;

            cbbx.DataSource = default;

            cbbx.ValueMember = nameof(ModeloExercicio.Item.Id);
            cbbx.DisplayMember = nameof(ModeloExercicio.Item.Descricao);

            cbbx.DataSource = servico.CriarLista();

            if (id is not null)
            {
                cbbx.SelectedValue = id;

                if (cbbx.SelectedValue is null
                    && cbbx.Items.Count > 0)
                    cbbx.SelectedIndex = 0;
            }

        }

        public static void VincularListaEnumTreinoTipos(this ComboBox cbbx)
        {
            var listaTreinoTipos = new Dictionary<TreinoTipo, string>
            {
                { 
                    TreinoTipo.TreinoA,
                    SuporteDados.ObterNomeTreinoTipo(TreinoTipo.TreinoA)
                },
                {
                    TreinoTipo.TreinoB,
                    SuporteDados.ObterNomeTreinoTipo(TreinoTipo.TreinoB)
                },
                {
                    TreinoTipo.TreinoC,
                    SuporteDados.ObterNomeTreinoTipo(TreinoTipo.TreinoC)
                },
                {
                    TreinoTipo.TreinoD,
                    SuporteDados.ObterNomeTreinoTipo(TreinoTipo.TreinoD)
                },
                {
                    TreinoTipo.TreinoE,
                    SuporteDados.ObterNomeTreinoTipo(TreinoTipo.TreinoE)
                },
                {
                    TreinoTipo.TreinoF,
                    SuporteDados.ObterNomeTreinoTipo(TreinoTipo.TreinoF)
                }
            };

            cbbx.ValueMember = nameof(KeyValuePair<TreinoTipo, string>.Key);
            cbbx.DisplayMember = nameof(KeyValuePair<TreinoTipo, string>.Value);
            cbbx.DataSource = listaTreinoTipos.ToArray();
        }

        public static void VincularListaEnumFormasPagamentos(this ComboBox cbbx)
        {
            var listaTreinoTipos = new Dictionary<FormasPagamentos, string>
            {
                { 
                    FormasPagamentos.Dinheiro,
                    SuporteDados.ObterNomeFormasPagamentos(FormasPagamentos.Dinheiro)
                },
                { 
                    FormasPagamentos.CartaoDebito,
                    SuporteDados.ObterNomeFormasPagamentos(FormasPagamentos.CartaoDebito)
                },
            };

            cbbx.ValueMember = nameof(KeyValuePair<TreinoTipo, string>.Key);
            cbbx.DisplayMember = nameof(KeyValuePair<TreinoTipo, string>.Value);
            cbbx.DataSource = listaTreinoTipos.ToArray();
        }

        public static void VincularListaTreinos(this ComboBox cbbx, IEnumerable<ModeloTreino.Item> treinos)
        {
            cbbx.ValueMember = nameof(ModeloTreino.Item.Id);
            cbbx.DisplayMember = nameof(ModeloTreino.Item.Descricao);
            cbbx.DataSource = treinos;
        }
    }
}
