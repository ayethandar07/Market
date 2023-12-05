using CoreBussiness;
using Microsoft.EntityFrameworkCore;

namespace Plugins.DataStore.SQL
{
    public class MarketContext : DbContext
    {
        public MarketContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        #region OnModelCreating
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //modelBuilder.Entity<Category>()
        //    //    .HasMany(c-)

        //    //seeding some data
        //    modelBuilder.Entity<Category>().HasData(
        //        new Category { CategoryId = 1, Name = "Beverage", Description = "Beverage" },
        //        new Category { CategoryId = 2, Name = "Bakery", Description = "Bakery" },
        //        new Category { CategoryId = 3, Name = "Meat", Description = "Meat" }
        //        );

        //}
        #endregion
    }
}