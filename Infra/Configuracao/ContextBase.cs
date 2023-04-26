using Entities.Entidades;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infra.Configuracao;

public class ContextBase : IdentityDbContext<AplicationUser>
{
    public ContextBase( DbContextOptions options ) : base(options)
    {
        
    }
    
    public DbSet<SistemaFinanceiro> SistemaFinanceiro { set; get; }
    public DbSet<UsuarioSistemaFinanceiro> UsuarioSistemaFinanceiro { get; set; }
    public DbSet<Categoria> Categoria { set; get; }
    public DbSet<Despesa> Despesa { set; get; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        if (!optionsBuilder.IsConfigured) {
            optionsBuilder.UseSqlServer(ObterStringConexao());
            base.OnConfiguring(optionsBuilder);
        }
    }

    protected void OnModeCreating(ModelBuilder builder)
    {
        builder.Entity<AplicationUser>().ToTable("AspNetUsers").HasKey(t => t.Id);
        
        base.OnModelCreating(builder);
    }

    public string ObterStringConexao() {
        return "Data Source=DESKTOP-GV4CRNN; Initial Catalog=FINANCEIRO_2023; Integrated Security=True";
    }
}