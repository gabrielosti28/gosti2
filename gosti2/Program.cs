using System;
using System.Windows.Forms;

namespace gosti2
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 1️⃣ INICIALIZAÇÃO DO BANCO
            try
            {
                using (var context = new ApplicationDbContext())
                {
                    context.Database.CreateIfNotExists(); // Cria banco se não existir
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao inicializar banco: {ex.Message}\n\n" +
                              "Verifique se o SQL Server está instalado.",
                              "Erro Crítico", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 2️⃣ FLUXO PRINCIPAL DA APLICAÇÃO
            while (true) // Loop para sempre voltar ao login após logout
            {
                // Tela de Login
                using (var formLogin = new FormLogin())
                {
                    var resultadoLogin = formLogin.ShowDialog();

                    if (resultadoLogin == DialogResult.OK && UserManager.UsuarioLogado != null)
                    {
                        // 3️⃣ SE LOGIN BEM-SUCEDIDO: Abre tela principal
                        using (var formPrincipal = new FormPrincipal())
                        {
                            Application.Run(formPrincipal);

                            // Quando formPrincipal fechar, volta para o login
                            UserManager.Logout(); // Garante logout
                        }
                    }
                    else
                    {
                        // 4️⃣ SE USUÁRIO CANCELOU: Pergunta se quer sair
                        if (MessageBox.Show("Deseja realmente sair do aplicativo?", "Sair",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            break; // Sai do loop e fecha aplicativo
                        }
                    }
                }
            }
        }
    }
}