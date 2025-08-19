using System;
using System.Windows.Forms;

namespace gosti2
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
            txtSenha.PasswordChar = '*';
            txtConfirmarSenha.PasswordChar = '*';
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos()) return;

            var novoUsuario = new User
            {
                Nome = txtNome.Text,
                Email = txtEmail.Text,
                Senha = txtSenha.Text, // Implementar hash depois
                DataNascimento = txtDataNascimento.Text,
                Bio = txtBio.Text
            };

            if (UserManager.CadastrarUsuario(novoUsuario))
            {
                MessageBox.Show("Cadastro realizado com sucesso!");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtSenha.Text) ||
                string.IsNullOrWhiteSpace(txtConfirmarSenha.Text) ||
                string.IsNullOrWhiteSpace(txtDataNascimento.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!");
                return false;
            }

            if (txtSenha.Text != txtConfirmarSenha.Text)
            {
                MessageBox.Show("As senhas não coincidem!");
                return false;
            }

            if (!txtEmail.Text.Contains("@"))
            {
                MessageBox.Show("Digite um email válido!");
                return false;
            }

            return true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}