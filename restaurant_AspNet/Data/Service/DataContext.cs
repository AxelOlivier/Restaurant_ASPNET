using Microsoft.EntityFrameworkCore;
using RestoApi.models;

namespace RestoApi.Data
{
    public class DataContext : DbContext, IDataContext
    {
        public DbSet<Table> Tables { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlite("Data Source=Resto.db");

        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>();
            
            if(condition){
            
            }
            if(condition){

            }

        }
        */

    }
}
