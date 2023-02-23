using SistemaAcademia.App.Suporte;

namespace SistemaAcademia.App
{
    public partial class FrmTelaAlunoPagamento : Form
    {
        public FrmTelaAlunoPagamento()
        {
            InitializeComponent();
        }

        private void FrmTelaAlunoPagamento_Load(object sender, EventArgs e)
        {
            cbbxFormaPagamento.VincularListaEnumFormasPagamentos();
        }
    }
}
