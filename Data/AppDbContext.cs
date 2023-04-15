using Microsoft.EntityFrameworkCore;
using PrimeiroProjetoBanco.Models;

namespace PrimeiroProjetoBanco.Data
{
    public class AppDbContext : DbContext
    {
        // Representação da tabela pessoa
        public DbSet<Pessoa> Pessoas { get; set; }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");
    }
}
