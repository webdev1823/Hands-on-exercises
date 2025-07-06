using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;

namespace RetailInventory;

public class RetailDbContext : DbContext
{
    public DbSet<Product> Products => Set<Product>();
    public DbSet<Category> Categories => Set<Category>();

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
       optionsBuilder.UseSqlServer(@"Server=DESKTOP-0BLJGNV;Database=RetailDb;Trusted_Connection=True;TrustServerCertificate=True");


    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasPrecision(10, 2);
    }
}
