
using Microsoft.EntityFrameworkCore;

namespace RetailInventory.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-0BLJGNV;Database=RetailDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
