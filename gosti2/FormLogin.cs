using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Windows.Forms;
using gosti2;

namespace gosti
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            this.Text = "Login";
            txtSenha.PasswordChar = '*'; // Esconde a senha
        }

       
        private void button2_Click(object sender, EventArgs e)
        {
            if (UserManager.ValidateLogin(txtEmail.Text, txtSenha.Text))
            {
                MessageBox.Show("Login feito com sucesso!", "Bem-vindo",
                              MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Email ou senha incorretos!", "Erro",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
