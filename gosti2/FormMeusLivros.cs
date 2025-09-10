using System;
using System.Windows.Forms;

namespace gosti2
{
    public partial class FormMeusLivros : Form
    {
        public FormMeusLivros()
        {
            InitializeComponent();
            CarregarLivros();
        }

        private void CarregarLivros()
        {
            // TODO: Substituir por lógica real de acesso a dados
            dataGridViewLivros.Rows.Clear();

            // Simulação de dados - cada livro tem um ID de usuário associado
            // O usuário logado tem ID = 1 (isso virá do UserManager.UsuarioLogado.UserId)
            int usuarioLogadoId = 1;

            // Adiciona livros com informações de proprietário
            dataGridViewLivros.Rows.Add("O Senhor dos Anéis", "J.R.R. Tolkien", "Fantasia", "Finalizado", usuarioLogadoId);
            dataGridViewLivros.Rows.Add("1984", "George Orwell", "Distopia", "Lendo", usuarioLogadoId);
            dataGridViewLivros.Rows.Add("Dom Casmurro", "Machado de Assis", "Romance", "Quero Ler", usuarioLogadoId);

            // Adiciona um livro de outro usuário (não deve ser removível)
            dataGridViewLivros.Rows.Add("Harry Potter", "J.K. Rowling", "Fantasia", "Finalizado", 2);

            // Esconde a coluna do userId (última coluna)
            dataGridViewLivros.Columns[dataGridViewLivros.Columns.Count - 1].Visible = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("📘 Funcionalidade de adicionar livro em desenvolvimento!", "Em Breve", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewLivros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um livro para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se o usuário é o proprietário do livro
            DataGridViewRow linhaSelecionada = dataGridViewLivros.SelectedRows[0];
            int livroUsuarioId = Convert.ToInt32(linhaSelecionada.Cells["colUsuarioId"].Value);
            int usuarioLogadoId = 1; // Isso virá do UserManager.UsuarioLogado.UserId

            if (livroUsuarioId != usuarioLogadoId)
            {
                MessageBox.Show("Você só pode editar os livros que adicionou.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MessageBox.Show("✏️ Funcionalidade de edição em desenvolvimento!", "Em Breve", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dataGridViewLivros.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um livro para remover.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verifica se o usuário é o proprietário do livro
            DataGridViewRow linhaSelecionada = dataGridViewLivros.SelectedRows[0];
            int livroUsuarioId = Convert.ToInt32(linhaSelecionada.Cells["colUsuarioId"].Value);
            int usuarioLogadoId = 1; // Isso virá do UserManager.UsuarioLogado.UserId

            if (livroUsuarioId != usuarioLogadoId)
            {
                MessageBox.Show("Você só pode remover os livros que adicionou.", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tituloLivro = linhaSelecionada.Cells["colTitulo"].Value.ToString();
            var result = MessageBox.Show($"Tem certeza que deseja remover o livro '{tituloLivro}'?", "Confirmar Remoção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                dataGridViewLivros.Rows.Remove(linhaSelecionada);
                MessageBox.Show("Livro removido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewLivros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewLivros_SelectionChanged(object sender, EventArgs e)
        {
            // Habilita/desabilita botões baseado na seleção e propriedade
            if (dataGridViewLivros.SelectedRows.Count > 0)
            {
                DataGridViewRow linhaSelecionada = dataGridViewLivros.SelectedRows[0];
                int livroUsuarioId = Convert.ToInt32(linhaSelecionada.Cells["colUsuarioId"].Value);
                int usuarioLogadoId = 1; // Isso virá do UserManager.UsuarioLogado.UserId

                bool usuarioEDono = (livroUsuarioId == usuarioLogadoId);

                btnEditar.Enabled = usuarioEDono;
                btnRemover.Enabled = usuarioEDono;

                // Altera a cor de fundo para indicar propriedade
                foreach (DataGridViewRow row in dataGridViewLivros.Rows)
                {
                    int rowUsuarioId = Convert.ToInt32(row.Cells["colUsuarioId"].Value);
                    if (rowUsuarioId == usuarioLogadoId)
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 248, 255); // Azul claro
                    }
                    else
                    {
                        row.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(255, 250, 240); // Laranja claro
                    }
                }
            }
            else
            {
                btnEditar.Enabled = false;
                btnRemover.Enabled = false;
            }
        }
    }
}