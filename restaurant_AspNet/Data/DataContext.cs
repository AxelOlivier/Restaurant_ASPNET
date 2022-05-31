using Microsoft.EntityFrameworkCore;
using RestoApi.models;

namespace RestoApi.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Table> Table { get; set; }
        public DbSet<Etat> Etat { get; set; }
        public DbSet<TypeAliment> TypeAliment { get; set; }
        public DbSet<Alimentaire> Alimentaire { get; set; }
        public DbSet<Commande> Commande { get; set; }

        public DataContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>();
            modelBuilder.Entity<Etat>();
            modelBuilder.Entity<TypeAliment>();
            modelBuilder.Entity<Alimentaire>();
            modelBuilder.Entity<Commande>();
        }
    }
}
