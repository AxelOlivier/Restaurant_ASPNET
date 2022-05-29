using Microsoft.EntityFrameworkCore;
using RestoApi.models;

namespace RestoApi.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Table> Tables { get; set; }

        public DataContext(DbContextOptions options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>();
        }
    }
}
