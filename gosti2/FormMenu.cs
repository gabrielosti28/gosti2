using System.Windows.Forms;
using gosti2;

namespace gosti
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            this.Text = "Menu Principal";
        }

       

        

       

        private void button1_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            new FormLogin().ShowDialog();
            this.Show(); // Volta ao menu após fechar o login
        }

        private void button2_Click(object sender, System.EventArgs e)
        {
            this.Hide();
            new FormCadastro().ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, System.EventArgs e)
        {
            if (MessageBox.Show("Deseja sair do programa?", "Confirmação",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}