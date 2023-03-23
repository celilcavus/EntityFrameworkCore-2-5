using Microsoft.EntityFrameworkCore;
using Models.Entitys;

namespace Models.Contexts
{
    public class MarketConext:DbContext
    {
        public DbSet<AlinanUrun>? AlinanUruns { get; set; }
        public DbSet<SatilanUrun>? SatilanUruns { get; set; }
        public DbSet<Firma>? Firmas { get; set; }
        public DbSet<Urun>? Uruns { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=LittleMarketDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}