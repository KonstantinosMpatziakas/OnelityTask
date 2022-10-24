using Microsoft.EntityFrameworkCore;
using OnelityTaskBackend.Models;
using SQLitePCL;
using Microsoft.Data.Sqlite;

namespace OnelityTaskBackend.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }


        public DbSet<Customer> Customer { get; set; }
        public DbSet<Cart> Cart { get; set; }
        public DbSet<Purchase> Purchase { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //1 to many
            //modelBuilder.Entity<Customer>().HasMany(a => a.Purchases).WithMany(b => b.Customer);
        }
    }
}
