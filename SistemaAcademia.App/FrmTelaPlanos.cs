using Microsoft.EntityFrameworkCore;

using SistemaAcademia.Dados.Entidades;
using SistemaAcademia.Dados.Modelos;
using SistemaAcademia.Dados.Servicos;

using System.Drawing;

namespace SistemaAcademia.App
{
    public partial class FrmTelaPlanos : Form
    {
        private readonly ServicoPlanos servicoPlanos;
        private long id;

        public FrmTelaPlanos()
        {
            InitializeComponent();

            servicoPlanos = new ServicoPlanos(Program.DbContext);
        }

        private void LimparCampos()
        {
            id = 0;

            txtDescricao.Clear();
            nmNumeroDias.Value = 30;
            txtValor.Clear();
            chbxCobradoMensalmente.Checked = false;

            btnExcluir.Visible = false;
        }

        private void RecarregarPlanos()
        {
            dgvPlanos.Rows.Clear();

            var planos = servicoPlanos.ListarTudo();

            foreach (var plano in planos)
                dgvPlanos.Rows.Add(plano.Id, plano.Descricao, plano.Valor);

            if (dgvPlanos.Rows.Count > 0 )
            {
                var index = dgvPlanos.Rows.GetLastRow(DataGridViewElementStates.Visible);

                dgvPlanos.Rows[index].Selected = true;
            }
        }

        private void FrmTelaPlanos_Load(object sender, EventArgs e)
        {
            try
            {
                RecarregarPlanos();

                nmNumeroDias.Value = 30;
                nmMesesCobrados.Value = 1;

                txtDescricao.Focus();
                txtDescricao.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AtualizarPlano(ModeloPlano.Detalhes modelo)
        {
            if (string.IsNullOrEmpty(txtDescricao.Text))
                throw new InvalidOperationException("A descrição não foi informada.");

            if (!decimal.TryParse(txtValor.Text, out var valor))
                throw new InvalidOperationException("O valor informado não é válido.");

            modelo.Descricao = txtDescricao.Text;
            modelo.MesesCobrados = (int)nmMesesCobrados.Value;
            modelo.Dias = (long)nmNumeroDias.Value;
            modelo.Valor = valor;
            modelo.CobradoMensalmente = chbxCobradoMensalmente.Checked;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (id == 0)
                {
                    var modelo = new ModeloPlano.Detalhes();

                    AtualizarPlano(modelo);

                    servicoPlanos.Criar(modelo);
                }
                else
                {
                    var modelo = new ModeloPlano.Detalhes();

                    AtualizarPlano(modelo);

                    servicoPlanos.Editar(id, modelo);
                }

                LimparCampos();
                RecarregarPlanos();

                MessageBox.Show(this, "O plano foi atualizado com sucesso.");

                txtDescricao.Focus();
                txtDescricao.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, "Tem certeza que deseja excluir o plano selecionado?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    servicoPlanos.Excluir(id);

                    LimparCampos();
                    RecarregarPlanos();

                    MessageBox.Show(this, "O plano foi excluído com sucesso.");

                    txtDescricao.Focus();
                    txtDescricao.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                LimparCampos();
                RecarregarPlanos();

                txtDescricao.Focus();
                txtDescricao.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPlanos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0
                    && e.ColumnIndex >= 0)
                {
                    id = (long)dgvPlanos[0, e.RowIndex].Value;

                    var plano = servicoPlanos.ObterDetalhes(id);

                    if (plano is null)
                    {
                        MessageBox.Show(this, "O plano não foi encontrado.");

                        return;
                    }

                    txtDescricao.Text = plano.Descricao;
                    chbxCobradoMensalmente.Checked = plano.CobradoMensalmente;

                    if (plano.CobradoMensalmente
                        && plano.MesesCobrados.HasValue)
                        nmMesesCobrados.Value = plano.MesesCobrados.Value;

                    txtValor.Text = plano.Valor.ToString();

                    nmNumeroDias.Value = plano.Dias;

                    btnExcluir.Visible = true;

                    txtDescricao.Focus();
                    txtDescricao.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chbxCobradoMensalmente_CheckedChanged(object sender, EventArgs e)
        {
            lbMesesMaximoParcelamento.Visible = chbxCobradoMensalmente.Checked;
            nmMesesCobrados.Visible = chbxCobradoMensalmente.Checked;

            nmMesesCobrados.Value = 1;
        }
    }
}
