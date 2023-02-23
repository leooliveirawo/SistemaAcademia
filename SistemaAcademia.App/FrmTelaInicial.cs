namespace SistemaAcademia.App
{
    public partial class FrmTelaInicial : Form
    {
        public FrmTelaInicial()
        {
            InitializeComponent();
        }

        private void planosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var frm = new FrmTelaPlanos();

            frm.ShowDialog(this);
        }

        private void exerciciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var frm = new FrmTelaExercicios();

            frm.ShowDialog(this);
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var frm = new FrmTelaAlunos();

            frm.ShowDialog(this);
        }

        private void treinosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var frm = new FrmTelaAlunos(FrmTelaAlunos.Modos.Treinos);

            frm.ShowDialog(this);
        }

        private void imprimirTreinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var frm = new FrmTelaAlunos(FrmTelaAlunos.Modos.ImprimirTreino);

            frm.ShowDialog(this);
        }

        private void pagamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var frm = new FrmTelaAlunos(FrmTelaAlunos.Modos.Pagamentos);

            frm.ShowDialog(this);
        }
    }
}