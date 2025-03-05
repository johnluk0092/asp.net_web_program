using Microsoft.EntityFrameworkCore;

namespace WebsiteBanHang.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { } //newly added
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        // Override OnModelCreating to configure model properties (newly add)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fix precision issue for decimal Price
            modelBuilder.Entity<Product>()
                .Property(p => p.Price)
                .HasColumnType("decimal(18,2)");

            base.OnModelCreating(modelBuilder);
        }
    }
}
