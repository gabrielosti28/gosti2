using System.Windows.Forms;
using gosti2;

namespace gosti
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            this.Text = "Bem-vindo"; 
        }

       
        

        private void btnAvancar_Click_1(object sender, System.EventArgs e)
        {
            this.Hide(); 
            new FormMenu().ShowDialog(); 
            this.Close(); 
        }

        private void btnSair_Click_1(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        private void btnInformações_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            new infoTela().ShowDialog();
            this.Close();
        }
    }
}