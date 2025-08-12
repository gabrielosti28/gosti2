namespace gosti
{
    partial class FormCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSair2 = new System.Windows.Forms.Button();
            this.btnCadastar = new System.Windows.Forms.Button();
            this.Senha = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.Label();
            this.Nome = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.Data = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSair2
            // 
            this.btnSair2.Location = new System.Drawing.Point(705, 335);
            this.btnSair2.Name = "btnSair2";
            this.btnSair2.Size = new System.Drawing.Size(202, 115);
            this.btnSair2.TabIndex = 2;
            this.btnSair2.Text = "Sair";
            this.btnSair2.UseVisualStyleBackColor = true;
            // 
            // btnCadastar
            // 
            this.btnCadastar.Location = new System.Drawing.Point(705, 191);
            this.btnCadastar.Name = "btnCadastar";
            this.btnCadastar.Size = new System.Drawing.Size(202, 115);
            this.btnCadastar.TabIndex = 3;
            this.btnCadastar.Text = "Cadastar";
            this.btnCadastar.UseVisualStyleBackColor = true;
            this.btnCadastar.Click += new System.EventHandler(this.btnCadastar_Click);
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Location = new System.Drawing.Point(291, 88);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(41, 13);
            this.Senha.TabIndex = 9;
            this.Senha.Text = "Senha:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(251, 116);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.AutoSize = true;
            this.txtEmail.Location = new System.Drawing.Point(84, 88);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(35, 13);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.Text = "Email:";
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(291, 191);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(38, 13);
            this.Nome.TabIndex = 13;
            this.Nome.Text = "Nome:";
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(53, 219);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 12;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(251, 219);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 11;
            // 
            // Data
            // 
            this.Data.AutoSize = true;
            this.Data.Location = new System.Drawing.Point(84, 191);
            this.Data.Name = "Data";
            this.Data.Size = new System.Drawing.Size(30, 13);
            this.Data.TabIndex = 10;
            this.Data.Text = "Data";
            this.Data.Click += new System.EventHandler(this.label4_Click);
            // 
            // FormCadastro
            // 
            this.ClientSize = new System.Drawing.Size(1128, 497);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.Data);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnCadastar);
            this.Controls.Add(this.btnSair2);
            this.Name = "FormCadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSair2;
        private System.Windows.Forms.Button btnCadastar;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label txtEmail;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label Data;
    }
}