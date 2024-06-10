using KhumaloCraft.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace KhumaloCraft.Data
{
    public class KhumaloCraftDbContext: IdentityDbContext<ApplicationUser>
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }


        public KhumaloCraftDbContext(DbContextOptions options): base (options)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var admin = new IdentityRole("admin");
            admin.NormalizedName = "admin";

            var client = new IdentityRole("client");
            client.NormalizedName = "client";

            var seller = new IdentityRole("seller");
            seller.NormalizedName = "seller";

            builder.Entity<IdentityRole>().HasData(admin,client,seller);

            builder.Entity<Category>()
                .HasKey(c => c.CatID);

            builder.Entity<Product>()
                .HasKey(c => c.ProductID);

            builder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("float"); // Adjust precision and scale as neededbuilder.Entity<Product>()
            
            builder.Entity<Order>()
                .Property(o => o.Total)
                .HasColumnType("float"); // Change the precision to fit your needs

            builder.Entity<OrderDetail>()
                .Property(o => o.SubTotal)
                .HasColumnType("float"); // Change the precision to fit your needs
        }
    }
}
