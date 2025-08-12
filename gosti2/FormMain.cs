using System.Windows.Forms;
using gosti2;

namespace gosti
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.Text = "Bem-vindo"; // Título da janela
        }

       
        

        private void btnAvancar_Click_1(object sender, System.EventArgs e)
        {
            this.Hide(); // Esconde a tela atual
            new FormMenu().ShowDialog(); // Abre o menu
            this.Close(); // Fecha a tela inicial quando voltar
        }

        private void btnSair_Click_1(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit(); // Fecha o programa
            }
        }
    }
}