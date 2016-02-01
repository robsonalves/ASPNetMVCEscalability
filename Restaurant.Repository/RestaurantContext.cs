using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Restaurant.Entity;

namespace Restaurant.Repository
{
    public class RestaurantContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Waiter> Waiters { get; set; }

        public RestaurantContext() : base("DefaultConnection") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer(new RestaurantContextInitializer());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
                     
            modelBuilder.Entity<Order>().HasMany(e => e.Products);

            modelBuilder.Entity<Order>().HasRequired(t => t.Waiter);

            base.OnModelCreating(modelBuilder);
        }
    }

    internal class RestaurantContextInitializer : CreateDatabaseIfNotExists<RestaurantContext>
    {
        protected override void Seed(RestaurantContext context)
        {
            base.Seed(context);
        }
    }
}
