using Microsoft.EntityFrameworkCore;
using Ventas.Shared.Entities;

namespace Ventas.API.Data
{
    public class DataContext:DbContext
    {
        // debe heredar de db context
        // conexion con la bd 
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c=>c.Name).IsUnique(); 
            //El nombre es unico, esccribes dos veces el mismo no dejara 
            //Esto no deja escribir lo msmo 2 vcs
        }

    }
}
