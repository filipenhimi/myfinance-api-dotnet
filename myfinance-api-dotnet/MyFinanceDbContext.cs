using Microsoft.EntityFrameworkCore;
using myfinance_api_dotnet.Domain;

namespace myfinance_api_dotnet
{
    public class MyFinanceDbContext : DbContext
    {
        public DbSet<PlanoConta> PlanoConta { get; set; }
        public DbSet<Transacao> Transacao { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=LOCALHOST\SQLEXPRESS;Database=myfinance;Trusted_Connection=True;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
