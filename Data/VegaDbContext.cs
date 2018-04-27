using Microsoft.EntityFrameworkCore;
using vega.Models;

namespace vega.Data
{
    public class VegaDbContext : DbContext
    {
        public VegaDbContext(DbContextOptions<VegaDbContext> options) : base(options)
        {
            
        }

        public DbSet<Model> Models {get;set;}
        public DbSet<Make> Makes {get;set;}


        // protected override void OnModelCreating(ModelBuilder modelBuilder){
        //     modelBuilder.Entity<Model>().ToTable("Model");
        //     modelBuilder.Entity<Make>().ToTable("Make");

        // }
    }
}