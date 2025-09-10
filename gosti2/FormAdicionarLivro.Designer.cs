namespace gosti2
{
    partial class FormAdicionarLivro
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FormAdicionarLivro
            // 
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Name = "FormAdicionarLivro";
            this.Text = "Adicionar Novo Livro";
            this.Load += new System.EventHandler(this.FormAdicionarLivro_Load_1);
            this.ResumeLayout(false);

        }
    }
}