using System;
using System.Windows.Forms;
using gosti2;

namespace gosti
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
            this.Text = "Cadastro";
            Senha.PasswordChar = '*'; // Esconde a senha com *
        }

        private void btnCadastrar_Click(object sender, EventArgs e) // Renomeado para btnCadastrar
        {
            // Verifica se todos os campos estão preenchidos
            if (string.IsNullOrWhiteSpace(Nome.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(Senha.Text) ||
                string.IsNullOrWhiteSpace(Data.Text))
            {
                MessageBox.Show("Preencha todos os campos!", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validação básica de email
            if (!txtEmail.Text.Contains("@") || !txtEmail.Text.Contains("."))
            {
                MessageBox.Show("Por favor, insira um email válido!", "Aviso",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Cria um novo usuário
            User newUser = new User()
            {
                Nome = Nome.Text,
                Email = txtEmail.Text,
                Senha = Senha.Text,
                DataNascimento = Data.Text
            };

            // Adiciona ao gerenciador (CORREÇÃO AQUI)
            UserManager.AddUser(newUser);
            MessageBox.Show("Cadastro realizado!", "Sucesso",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Fecha a tela
        }

        private void btnSair_Click(object sender, EventArgs e) // Padronize o nome
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}