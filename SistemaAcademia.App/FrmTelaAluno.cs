using SistemaAcademia.App.Suporte;
using SistemaAcademia.Dados.Modelos;
using SistemaAcademia.Dados.Servicos;
using SistemaAcademia.Dados.Valores;

using static SistemaAcademia.Dados.Modelos.ModeloAluno.Detalhes;

namespace SistemaAcademia.App
{
    public partial class FrmTelaAluno : Form
    {
        private readonly ServicoPlanos servicoPlano;
        private readonly ServicoAlunos servicoAlunos;

        private readonly long alunoId;

        private ModeloAluno.Detalhes aluno;

        private int telefoneIndex;

        public FrmTelaAluno(long alunoId = 0)
        {
            InitializeComponent();

            servicoPlano = new ServicoPlanos(Program.DbContext);
            servicoAlunos = new ServicoAlunos(Program.DbContext);

            this.alunoId = alunoId;

            aluno = new ModeloAluno.Detalhes();

            telefoneIndex = -1;
        }

        private void RecarregarPlanos()
        {
            cbbxPlano.VincularListaPlanos(servicoPlano);
        }

        private void LimparCamposTelefone()
        {
            txtTelefoneDDD.Clear();
            txtTelefoneNumero.Clear();

            cbbxTelefoneTipo.SelectedIndex = 0;
            chbxTelefonePossuiWhatsApp.Checked = false;

            telefoneIndex = -1;

            btnExcluir.Visible = false;
        }

        private void FrmTelaAluno_Load(object sender, EventArgs e)
        {
            try
            {
                if (alunoId == 0)
                {
                    RecarregarPlanos();

                    treinosToolStripMenuItem.Visible = false;

                    cbbxTelefoneTipo.SelectedIndex = 0;

                    txtNomeCompleto.Focus();
                    txtNomeCompleto.SelectAll();
                }
                else
                {
                    var aluno = servicoAlunos.ObterDetalhes(alunoId);

                    if (aluno is null)
                    {
                        MessageBox.Show(this, "O aluno não foi encontrado.");

                        Close();
                        
                        return;
                    }

                    this.aluno = aluno;

                    txtNomeCompleto.Text = aluno.NomeCompleto;
                    txtCPF.Text = aluno.CPF;

                    RecarregarPlanos();
                    
                    cbbxPlano.SelectedValue = aluno.PlanoId;

                    if (cbbxPlano.Items.Count > 0
                        && cbbxPlano.SelectedValue is null)
                        cbbxPlano.SelectedIndex = 0;

                    txtLogradouro.Text = aluno.Logradouro;
                    txtCEP.Text = aluno.CEP;
                    txtComplemento.Text = aluno.Complemento;
                    txtBairro.Text = aluno.Bairro;
                    txtCidade.Text = aluno.Cidade;
                    txtEstadoUF.Text = aluno.EstadoUF;

                    aluno.Telefones.ToList().ForEach(x =>
                    {
                        dgvTelefones.Rows.Add(x.DDD, x.Numero, x.Tipo);
                    });

                    cbbxTelefoneTipo.SelectedIndex = 0;

                    txtNomeCompleto.Focus();
                    txtNomeCompleto.SelectAll();
                }
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
                AtualizarAluno(aluno);

                var resultado = servicoAlunos.Validar(aluno);

                if (!resultado.IsValid)
                {
                    var pilhaMensagens = $"Detalhes da validação:\n";

                    foreach(var erro in resultado.Errors)
                    {
                        pilhaMensagens += $"\n - {erro.ErrorMessage};";
                    }

                    MessageBox.Show(this, $"Não foi possível concluir a operação, pois um ou mais campos não são validados.\n\n{pilhaMensagens}", "Erro de validação");

                    return;
                }

                if (alunoId == 0)
                {
                    servicoAlunos.Criar(aluno);

                    MessageBox.Show(this, "O aluno foi cadastrado com sucesso.");
                }
                else
                {
                    servicoAlunos.Editar(alunoId, aluno);

                    MessageBox.Show(this, "O aluno foi alterado com sucesso.");
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            void AtualizarAluno(ModeloAluno.Detalhes aluno)
            {
                aluno.NomeCompleto = txtNomeCompleto.Text;
                aluno.CPF = txtCPF.Text;

                if (cbbxPlano.SelectedValue is not null)
                    aluno.PlanoId = (long)cbbxPlano.SelectedValue;
                else
                    aluno.PlanoId = -1;

                aluno.Logradouro = txtLogradouro.Text;
                aluno.Complemento = txtComplemento.Text;
                aluno.CEP = txtCEP.Text;
                aluno.Bairro = txtBairro.Text;
                aluno.Cidade = txtCidade.Text;
                aluno.EstadoUF = txtEstadoUF.Text;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void planosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using var frm = new FrmTelaPlanos();

                frm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRecarregarPlanos_Click(object sender, EventArgs e)
        {
            try
            {
                RecarregarPlanos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbDados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tbDados.SelectedTab == tbpDadosPessoais)
            {
                txtNomeCompleto.Focus();
                txtNomeCompleto.SelectAll();
            }
            else if (tbDados.SelectedTab == tbpLocalidade)
            {
                txtLogradouro.Focus();
                txtLogradouro.SelectAll();
            }
        }

        private void dgvTelefones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0
                    && e.ColumnIndex >= 0)
                {
                    telefoneIndex = e.RowIndex;

                    var telefone = aluno.Telefones.ElementAt(telefoneIndex);

                    txtTelefoneDDD.Text = telefone.DDD;
                    txtTelefoneNumero.Text = telefone.Numero;

                    cbbxTelefoneTipo.SelectedIndex = (int)telefone.Tipo;
                    chbxTelefonePossuiWhatsApp.Checked = telefone.PossuiWhatsApp;

                    btnExcluir.Visible = true;

                    txtTelefoneDDD.Focus();
                    txtTelefoneDDD.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTelefoneSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (telefoneIndex == -1)
                {
                    var telefone = new Telefone
                    {
                        DDD = txtTelefoneDDD.Text,
                        Numero = txtTelefoneNumero.Text,
                        Tipo = (TelefoneTipo)cbbxTelefoneTipo.SelectedIndex,
                        PossuiWhatsApp = chbxTelefonePossuiWhatsApp.Checked
                    };

                    aluno.Telefones.Add(telefone);

                    var index = dgvTelefones.Rows.Add(telefone.DDD, telefone.Numero, telefone.Tipo);

                    dgvTelefones.Rows[index].Selected = true;
                }
                else
                {
                    var telefone = aluno.Telefones.ElementAt(telefoneIndex);

                    telefone.DDD = txtTelefoneDDD.Text;
                    telefone.Numero = txtTelefoneNumero.Text;
                    telefone.Tipo = (TelefoneTipo)cbbxTelefoneTipo.SelectedIndex;
                    telefone.PossuiWhatsApp = chbxTelefonePossuiWhatsApp.Checked;

                    dgvTelefones[0, telefoneIndex].Value = telefone.DDD;
                    dgvTelefones[1, telefoneIndex].Value = telefone.Numero;
                    dgvTelefones[2, telefoneIndex].Value = telefone.Tipo;
                }

                LimparCamposTelefone();

                txtTelefoneDDD.Focus();
                txtTelefoneDDD.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTelefoneCancelar_Click(object sender, EventArgs e)
        {
            LimparCamposTelefone();

            txtTelefoneDDD.Focus();
            txtTelefoneDDD.SelectAll();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(this, "Tem certeza que deseja excluir o telefone selecionado?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    aluno.Telefones.Remove(aluno.Telefones.ElementAt(telefoneIndex));
                    dgvTelefones.Rows.RemoveAt(telefoneIndex);

                    if (dgvTelefones.Rows.Count > 0)
                    {
                        var index = dgvTelefones.Rows.GetLastRow(DataGridViewElementStates.Visible);
                        dgvTelefones.Rows[index].Selected = true; 
                    }

                    LimparCamposTelefone();

                    txtTelefoneDDD.Focus();
                    txtTelefoneDDD.SelectAll();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTelefonesLimpar_Click(object sender, EventArgs e)
        {
            LimparCamposTelefone();

            dgvTelefones.Rows.Clear();
            aluno.Telefones.Clear();

            txtTelefoneDDD.Focus();
            txtTelefoneDDD.SelectAll();
        }

        private void treinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                using var frm = new FrmTelaAlunoTreinos(alunoId);

                frm.ShowDialog(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
