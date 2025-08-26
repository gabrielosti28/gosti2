using System;
using System.Windows.Forms;
using gosti;

namespace gosti2
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            txtSenha.PasswordChar = '*';
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            if (UserManager.Login(txtEmail.Text, txtSenha.Text))
            {
                MessageBox.Show($"Bem-vindo, {UserManager.UsuarioLogado.Nome}!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos!");
            }
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var formCadastro = new FormCadastro())
            {
                formCadastro.ShowDialog();
            }
            this.Show();
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }
    }
}