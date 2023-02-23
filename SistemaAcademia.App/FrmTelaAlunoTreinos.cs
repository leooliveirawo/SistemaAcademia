using SistemaAcademia.App.Suporte;
using SistemaAcademia.Dados.Modelos;
using SistemaAcademia.Dados.Servicos;

namespace SistemaAcademia.App
{
    public partial class FrmTelaAlunoTreinos : Form
    {
        private readonly ServicoAlunos servicoAlunos;
        private readonly ServicoTreinos servicoTreinos;
        private readonly ServicoExercicios servicoExercicios;

        private readonly long alunoId;

        private IEnumerable<ModeloTreino.Detalhes> treinos = null!;

        public FrmTelaAlunoTreinos(long alunoId)
        {
            InitializeComponent();

            servicoAlunos = new ServicoAlunos(Program.DbContext);
            servicoExercicios = new ServicoExercicios(Program.DbContext);
            servicoTreinos = new ServicoTreinos(Program.DbContext);

            this.alunoId = alunoId;
        }

        private void RecarregarExercicios()
        {
            cbbxExercicio.VincularListaExercicios(servicoExercicios);
        }

        private void FrmTelaAlunoTreinos_Load(object sender, EventArgs e)
        {
            try
            {
                var aluno = servicoAlunos.ObterDetalhesSomenteNomeCompletoCPF(alunoId);

                treinos = servicoTreinos.ObterTodosDetalhesPorAlunoId(alunoId);

                if (aluno is null)
                {
                    MessageBox.Show(this, "O aluno não foi encontrado.");

                    Close();

                    return;
                }

                txtNomeCompleto.Text = aluno.NomeCompleto;
                txtCPF.Text = aluno.CPF;

                cbbxTreino.VincularListaEnumTreinoTipos();

                RecarregarExercicios();

                cbbxExercicio.SelectedIndex = 0;
                cbbxTreino.SelectedIndex = -1;
                cbbxTreino.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            foreach (var treino in treinos)
                treino.Exercicios.Clear();

            dgvExercicios.Rows.Clear();
        }

        private void cbbxTreino_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (treinos.Any()
                    && cbbxTreino.SelectedIndex >= 0)
                {
                    txtTreinoTipo.Text = cbbxTreino.Text;

                    var treinoSelecionado = treinos.ElementAt(cbbxTreino.SelectedIndex);

                    dgvExercicios.Rows.Clear();

                    RecarregarExercicios();

                    chbxTreinoAtivo.Checked = treinoSelecionado.Ativo;

                    foreach (var exercicioSelecionado in treinoSelecionado.Exercicios)
                    {
                        var exercicio = servicoExercicios.ObterItemPorId(exercicioSelecionado.ExercicioId);

                        if (exercicio is null)
                        {
                            MessageBox.Show(this, "Um ou mais exercicios dos treinos dos alunos não foram encontrados.");

                            Close();

                            return;
                        }

                        dgvExercicios.Rows.Add($"{exercicio.Descricao} {exercicioSelecionado.NumeroSeries} x {exercicioSelecionado.NumeroRepeticoes})");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExercicioIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (treinos.Any())
                {
                    var treinoSelecionado = treinos.ElementAt(cbbxTreino.SelectedIndex);

                    treinoSelecionado.Exercicios.Add(new ModeloTreino.Detalhes.Exercicio
                    {
                        #nullable disable
                        ExercicioId = (long)cbbxExercicio.SelectedValue,
                        NumeroSeries = (long)nmExercicioSeries.Value,
                        NumeroRepeticoes = (long)nmExercicioRepeticoes.Value
                        #nullable enable
                    });

                    dgvExercicios.Rows.Add($"{cbbxExercicio.Text} ({nmExercicioSeries.Value} x {nmExercicioRepeticoes.Value})");

                    if (dgvExercicios.Rows.Count > 0)
                    {
                        var index = dgvExercicios.Rows.GetLastRow(DataGridViewElementStates.Visible);

                        dgvExercicios.Rows[index].Selected = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExerciciosLimpar_Click(object sender, EventArgs e)
        {
            if (treinos.Any())
            {
                var treinoSelecionado = treinos.ElementAt(cbbxTreino.SelectedIndex);

                treinoSelecionado.Exercicios.Clear();
                dgvExercicios.Rows.Clear();
            }
        }

        private void chbxTreinoAtivo_CheckedChanged(object sender, EventArgs e)
        {
            if (treinos.Any())
            {
                var treinoSelecionado = treinos.ElementAt(cbbxTreino.SelectedIndex);

                treinoSelecionado.Ativo = chbxTreinoAtivo.Checked;
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                servicoTreinos.AtualizarTreinos(alunoId, treinos);

                MessageBox.Show(this, "Os treinos foram atualizados.");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void imprimirTreinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var frm = new FrmTelaImprimirTreino(alunoId);
            frm.ShowDialog(this);
        }

        private void exerciciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using var frm = new FrmTelaExercicios();

                frm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
