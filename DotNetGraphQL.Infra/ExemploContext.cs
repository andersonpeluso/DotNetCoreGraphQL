using Microsoft.EntityFrameworkCore;

namespace DotNetGraphQL.Infra
{
    public class ExemploContext : DbContext
    {
        public ExemploContext(DbContextOptions<ExemploContext> opcoes) : base(opcoes)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}