using gosti2;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext() : base("name=DefaultConnection")
    {
    }

    // Tabelas - NOME ATUALIZADO
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Livro> Livros { get; set; }
    public DbSet<CategoriaTier> CategoriasTier { get; set; }
    public DbSet<Mensagem> Mensagens { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        // Configuração opcional para nome personalizado da tabela
        modelBuilder.Entity<Usuario>().ToTable("Usuarios");
        modelBuilder.Entity<Livro>().ToTable("Livros");
        modelBuilder.Entity<Mensagem>().ToTable("Mensagens");

        base.OnModelCreating(modelBuilder);
    }
}