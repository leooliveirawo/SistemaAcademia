using Microsoft.EntityFrameworkCore;

using SistemaAcademia.Dados.Entidades;

using System.Data;

namespace SistemaAcademia.App
{
    public partial class FrmTelaExercicios : Form
    {
        private long id;

        public FrmTelaExercicios()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            id = 0;

            txtDescricao.Clear();

            btnExcluir.Visible = false;
        }

        private void RecarregarExercicios()
        {
            dgvExercicios.Rows.Clear();

            Program.DbContext.Exercicios
                .AsNoTracking()
                .Select(x => new
                {
                    x.Id,
                    x.Descricao,
                })
                .ToList()
                .ForEach(x => dgvExercicios.Rows.Add(x.Id, x.Descricao));

            if (dgvExercicios.Rows.Count > 0)
            {
                dgvExercicios.Rows[dgvExercicios.Rows.GetLastRow(DataGridViewElementStates.Visible)].Selected = true;
            }
        }

        private void FrmTelaExercicios_Load(object sender, EventArgs e)
        {
            try
            {
                RecarregarExercicios();

                txtDescricao.Focus();
                txtDescricao.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtDescricao.Text))
                {
                    MessageBox.Show(this, "A descrição não foi informada.");

                    return;
                }

                if (id == 0)
                {
                    var exercicio = new Exercicio
                    {
                        Descricao = txtDescricao.Text
                    };
                    Program.DbContext.Add(exercicio);
                    Program.DbContext.SaveChanges();
                }
                else
                {
                    var exercicio = Program.DbContext.Exercicios.SingleOrDefault(x => x.Id == id);

                    if (exercicio is null)
                    {
                        MessageBox.Show(this, "O exercicio não foi encontrado.");

                        return;
                    }

                    exercicio.Descricao = txtDescricao.Text;

                    Program.DbContext.Update(exercicio);
                    Program.DbContext.SaveChanges();
                }

                LimparCampos();
                RecarregarExercicios();

                MessageBox.Show(this, "O exercicio foi atualizado com sucesso.");

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
                if (MessageBox.Show(this, "Tem certeza que deseja excluir o exercicio selecionado?", "Confirmar exclusão", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var exercicio = Program.DbContext.Exercicios
                        .SingleOrDefault(x => x.Id == id);

                    if (exercicio is null)
                    {
                        MessageBox.Show(this, "O exercicio não foi encontrado.");

                        return;
                    }

                    Program.DbContext.Remove(exercicio);
                    Program.DbContext.SaveChanges();

                    LimparCampos();
                    RecarregarExercicios();

                    MessageBox.Show(this, "O exercicio foi excluído com sucesso.");

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
                RecarregarExercicios();

                txtDescricao.Focus();
                txtDescricao.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvExercicios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0
                    && e.ColumnIndex >= 0)
                {
                    id = (long)dgvExercicios[0, e.RowIndex].Value;

                    var plano = Program.DbContext.Exercicios
                        .AsNoTracking()
                        .Where(x => x.Id == id)
                        .Select(x => new
                        {
                            x.Descricao
                        })
                        .SingleOrDefault();

                    if (plano is null)
                    {
                        MessageBox.Show(this, "O exercicio não foi encontrado.");

                        return;
                    }

                    txtDescricao.Text = plano.Descricao;

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

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            RecarregarExercicios();
        }
    }
}
