using SistemaAcademia.App.Suporte;
using SistemaAcademia.Dados.Entidades;
using SistemaAcademia.Dados.Modelos;
using SistemaAcademia.Dados.Servicos;
using SistemaAcademia.Dados.Suporte;
using SistemaAcademia.Dados.Valores;

using System.Drawing.Printing;

namespace SistemaAcademia.App
{
    public partial class FrmTelaImprimirTreino : Form
    {
        private readonly long alunoId;
        private readonly ServicoTreinos servicoTreinos;

        private IEnumerable<ModeloTreino.Item> treinos = null!;

        public FrmTelaImprimirTreino(long alunoId)
        {
            InitializeComponent();

            this.alunoId = alunoId;
            this.servicoTreinos = new ServicoTreinos(Program.DbContext);
        }

        private void FrmTelaImprimirTreino_Load(object sender, EventArgs e)
        {
            try
            {
                treinos = servicoTreinos.CriarLista(alunoId);

                if (treinos is null)
                {
                    MessageBox.Show(this, "O aluno não possui treinos.");

                    Close();

                    return;
                }

                cbbxTreino.VincularListaTreinos(treinos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                var documento = new PrintDocument();

                documento.DefaultPageSettings.PaperSize = new PaperSize(documento.DefaultPageSettings.PaperSize.PaperName, 219, documento.DefaultPageSettings.PaperSize.Height);

                var printDialog = new PrintPreviewDialog
                {
                    Document = documento,
                };

                documento.PrintPage += Documento_PrintPage;  

                printDialog.ShowDialog(this);

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private void Documento_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                var treino = treinos.ElementAt(cbbxTreino.SelectedIndex);

                var treinoDetalhes = servicoTreinos.ObterTreinoDetalhesPorId(treino.Id);

                if (treinoDetalhes is null)
                {
                    MessageBox.Show(this, "O treino não foi encontrado.");

                    return;
                }    

                var posicaoDeitadaAcrescimoInicio = 5f;
                var posicaoDeitadaDescontoFinal = 12f;

                var font = new Font("Times New Roman", 7);
                var cor = new SolidBrush(Color.Black);

                var nomeAcademia = "NOME DA ACADEMIA";
                var aluno = $"ALUNO: {treinoDetalhes.NomeCompleto}";
                var dataTreinoNumero = $"DATA {DateTime.Now:dd/MM/yyyy}         TREINO {treinoDetalhes.NumeroAtualTreino}/{treinoDetalhes.NumeroMaximoTreino}";
                var treinoTipo = SuporteDados.ObterNomeTreinoTipo(treino.Tipo);

                var espacamentos = "-";

                var posicaoDeitadaFinalComDesconto = e.PageSettings.PaperSize.Width - posicaoDeitadaDescontoFinal;

                if (e.Graphics is null)
                    return;

                while (e.Graphics.MeasureString(espacamentos, font).Width < posicaoDeitadaFinalComDesconto)
                    espacamentos += "-";

                var posicaoEmPe = 10f;

                posicaoEmPe = EscreverTexto(e.Graphics, font, cor, nomeAcademia, posicaoEmPe, posicaoDeitadaAcrescimoInicio);
                posicaoEmPe = EscreverTexto(e.Graphics, font, cor, espacamentos, posicaoEmPe, posicaoDeitadaAcrescimoInicio);
                posicaoEmPe = EscreverTexto(e.Graphics, font, cor, aluno, posicaoEmPe, posicaoDeitadaAcrescimoInicio);
                posicaoEmPe = EscreverTexto(e.Graphics, font, cor, dataTreinoNumero, posicaoEmPe, posicaoDeitadaAcrescimoInicio);
                posicaoEmPe = EscreverTexto(e.Graphics, font, cor, espacamentos, posicaoEmPe, posicaoDeitadaAcrescimoInicio);
                posicaoEmPe = EscreverTexto(e.Graphics, font, cor, treinoTipo, posicaoEmPe, posicaoDeitadaAcrescimoInicio);

                if (treinoDetalhes.NumeroAtualTreino >= treinoDetalhes.NumeroMaximoTreino)
                {
                    posicaoEmPe = EscreverTexto(e.Graphics, font, cor, espacamentos, posicaoEmPe, posicaoDeitadaAcrescimoInicio);

                    var texto1 = "Parabéns, você concluíu o seu treino.";
                    var texto2 = "Passe por uma avaliação com o seu instrutor";
                    var texto3 = "para obter um novo treino.";

                    posicaoEmPe = EscreverTexto(e.Graphics, font, cor, texto1, posicaoEmPe, posicaoDeitadaAcrescimoInicio);
                    posicaoEmPe = EscreverTexto(e.Graphics, font, cor, texto2, posicaoEmPe, posicaoDeitadaAcrescimoInicio);
                    posicaoEmPe = EscreverTexto(e.Graphics, font, cor, texto3, posicaoEmPe, posicaoDeitadaAcrescimoInicio);
                }

                posicaoEmPe = EscreverTexto(e.Graphics, font, cor, espacamentos, posicaoEmPe, posicaoDeitadaAcrescimoInicio);

                foreach (var exercicio in treinoDetalhes.Exercicios)
                {
                    var seriesRepeticoes = $"({exercicio.NumeroSeries}/{exercicio.NumeroRepeticoes})";

                    EscreverTextoSemMudarPosicaoEmPe(e.Graphics, font, cor, exercicio.ExercicioDescricao, posicaoEmPe, posicaoDeitadaAcrescimoInicio);

                    var posicaoDeitadaPersonalizado = (float)e.PageSettings.PaperSize.Width - e.Graphics.MeasureString(seriesRepeticoes, font).Width - posicaoDeitadaDescontoFinal;

                    posicaoEmPe = EscreverTexto(e.Graphics, font, cor, seriesRepeticoes, posicaoEmPe, posicaoDeitadaPersonalizado);
                }

                posicaoEmPe = EscreverTexto(e.Graphics, font, cor, espacamentos, posicaoEmPe, posicaoDeitadaAcrescimoInicio);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message);
            }
        }

        private static float CalcularNovaPosicaoEmPe(Graphics graphics, Font font, string nomeAcademia, float posicaoEmPe)
        {
            return posicaoEmPe + graphics.MeasureString(nomeAcademia, font).Height;
        }

        private static float EscreverTexto(Graphics graphics, Font font, SolidBrush cor, string texto, float posicaoEmPe, float posicaoDeitado)
        {
            graphics.DrawString(texto, font, cor, new PointF(posicaoDeitado, posicaoEmPe));

            return CalcularNovaPosicaoEmPe(graphics, font, texto, posicaoEmPe);
        }

        private static void EscreverTextoSemMudarPosicaoEmPe(Graphics graphics, Font font, SolidBrush cor, string texto, float posicaoEmPe, float posicaoDeitado)
        {
            graphics.DrawString(texto, font, cor, new PointF(posicaoDeitado, posicaoEmPe));
        }
    }
}
