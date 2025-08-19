using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace gosti2
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=DefaultConnection")
        {
        }

        // Tabelas
        public DbSet<User> Users { get; set; }
        public DbSet<Livro> Livros { get; set; }
        public DbSet<CategoriaTier> CategoriasTier { get; set; }
        public DbSet<Mensagem> Mensagens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            // Configuração da relação muitos-para-muitos entre CategoriaTier e Livro
            modelBuilder.Entity<CategoriaTier>()
                .HasMany(c => c.Livros)
                .WithMany()
                .Map(m =>
                {
                    m.ToTable("CategoriaLivro");
                    m.MapLeftKey("CategoriaId");
                    m.MapRightKey("LivroId");
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}