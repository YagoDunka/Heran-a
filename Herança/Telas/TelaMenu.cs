using Herança.Telas;

namespace Herança
{
    public partial class TelaMenu : Form
    {
        public TelaMenu()
        {
            InitializeComponent();
        }

        private void pessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* TelaCadastroPessoa tela = new TelaCadastroPessoa();
            tela.ShowDialog(); */

            new TelaCadastroPessoa().ShowDialog();
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TelaCadastroEmpresa().ShowDialog();
        }
    }
}