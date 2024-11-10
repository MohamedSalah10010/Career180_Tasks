using Microsoft.EntityFrameworkCore;

namespace Online_Shopping.Models
{
    public class shopContext: DbContext
    {
        
        public virtual DbSet<Product> Products { get; set; }  
        public virtual DbSet<Catalog> Catalogs { get; set; }


        public shopContext(DbContextOptions<shopContext> options):base(options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Catalog>().HasData(
            new Catalog { id = 1, name = "Electronics", desc = "All electronic devices" },
            new Catalog { id = 2, name = "Books", desc = "Collection of books" },
            new Catalog { id = 3, name = "Clothing", desc = "Apparel and accessories" },
            new Catalog { id = 4, name = "Home Appliances", desc = "Appliances for home use" },
            new Catalog { id = 5, name = "Toys", desc = "Kids' toys and games" }
        );

            modelBuilder.Entity<Product>().HasData(
                new Product { id = 1, name = "Laptop", price = 999.99m, desc = "High-performance laptop", amount = 15, cat_id = 1 },
                new Product { id = 2, name = "Smartphone", price = 599.99m, desc = "Latest model smartphone", amount = 30, cat_id = 1 },
                new Product { id = 3, name = "Novel", price = 19.99m, desc = "Best-selling novel", amount = 50, cat_id = 2 },
                new Product { id = 4, name = "T-shirt", price = 9.99m, desc = "Comfortable cotton T-shirt", amount = 100, cat_id = 3 },
                new Product { id = 5, name = "Blender", price = 49.99m, desc = "Kitchen blender with multiple settings", amount = 20, cat_id = 4 }
            );

            base.OnModelCreating( modelBuilder );
        }
    }
}
