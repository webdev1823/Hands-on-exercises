using System;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using RetailInventory.Models;  

class Program
{
    static async Task Main(string[] args)
    {
        using var context = new AppDbContext();

        Console.WriteLine("📦 All Products:");
        var products = await context.Products.Include(p => p.Category).ToListAsync();
        foreach (var p in products)
        {
            Console.WriteLine($"- {p.Name} - ₹{p.Price} - Category: {p.Category?.Name}");
        }

        Console.WriteLine("\n🔍 Find Product with ID = 1");
        var product = await context.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Id == 1);
        if (product != null)
        {
            Console.WriteLine($"Found: {product.Name} - ₹{product.Price}");
        }

        Console.WriteLine("\n💰 First Product over ₹50,000");
        var expensive = await context.Products.Include(p => p.Category).FirstOrDefaultAsync(p => p.Price > 50000);
        if (expensive != null)
        {
            Console.WriteLine($"Expensive: {expensive.Name} - ₹{expensive.Price}");
        }
    }
}
