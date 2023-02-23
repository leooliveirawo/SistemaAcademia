using Microsoft.EntityFrameworkCore;

using System.Data;

namespace SistemaAcademia.App
{
    public partial class FrmTelaAlunos : Form
    {
        private readonly Modos modo;

        public enum Modos
        {
            Cadastro,
            Treinos,
            ImprimirTreino,
            Pagamentos
        }

        public FrmTelaAlunos(Modos modo = Modos.Cadastro)
        {
            InitializeComponent();

            this.modo = modo;
        }

        private void RecarregarAlunos()
        {
            dgvAlunos.Rows.Clear();

            var consulta = Program.DbContext.Alunos
                .Include(x => x.Plano)
                .Include(x => x.Mensalidades)
                .AsNoTracking();

            if (!string.IsNullOrWhiteSpace(txtBuscarPorNomeCompleto.Text))
                consulta = consulta.Where(x => x.NomeCompleto.Contains(txtBuscarPorNomeCompleto.Text));

            var sql = consulta
                .Select(x => new
                {
                    x.Id,
                    x.NomeCompleto,
                    PlanoDescricao = x.Plano.Descricao,
                    Venceu = !x.Mensalidades.Any(x => x.TerminaEm <= DateTime.Now)
                }).ToQueryString();

            consulta
                .Select(x => new
                {
                    x.Id,
                    x.NomeCompleto,
                    PlanoDescricao = x.Plano.Descricao,
                    Venceu = x.Mensalidades.Any(x => x.TerminaEm >= DateTime.Now)
                })
                .ToList()
                .ForEach(x =>
                {
                    var index = dgvAlunos.Rows.Add(x.Id, x.NomeCompleto, x.PlanoDescricao);

                    if (x.Venceu)
                    {
                        dgvAlunos.Rows[index].DefaultCellStyle.BackColor = Color.MediumSeaGreen;
                        dgvAlunos.Rows[index].DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
                    }
                    else
                    {
                        dgvAlunos.Rows[index].DefaultCellStyle.BackColor = Color.Firebrick;
                        dgvAlunos.Rows[index].DefaultCellStyle.SelectionBackColor = Color.DarkRed;
                    }
                });
            
            if (dgvAlunos.Rows.Count > 0)
            {
                dgvAlunos.Rows[dgvAlunos.Rows.GetLastRow(DataGridViewElementStates.Visible)].Selected = true;
            }
        }

        private void FrmTelaAlunos_Load(object sender, EventArgs e)
        {
            try
            {
                if (modo != Modos.Cadastro)
                    btnCadastrar.Visible = false;

                RecarregarAlunos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                using var frm = new FrmTelaAluno();

                frm.ShowDialog(this);

                RecarregarAlunos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBuscarPorNomeCompleto_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RecarregarAlunos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvAlunos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0
                    && e.ColumnIndex >= 0)
                {

                    if (modo == Modos.Treinos)
                    {
                        using var frm = new FrmTelaAlunoTreinos((long)dgvAlunos[0, e.RowIndex].Value);

                        frm.ShowDialog(this);
                    }
                    else if (modo == Modos.Cadastro)
                    {
                        using var frm = new FrmTelaAluno((long)dgvAlunos[0, e.RowIndex].Value);

                        frm.ShowDialog(this);

                        RecarregarAlunos();
                    }
                    else if (modo == Modos.ImprimirTreino)
                    {
                        using var frm = new FrmTelaImprimirTreino((long)dgvAlunos[0, e.RowIndex].Value);

                        frm.ShowDialog(this);
                    }
                    else
                    {
                        using var frm = new FrmTelaAlunoPagamento();

                        frm.ShowDialog(this);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
