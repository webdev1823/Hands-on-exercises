using System;

class Program
{
    static void Main(string[] args)
    {
        Product[] products = {
            new Product(102, "Keyboard", "Electronics"),
            new Product(101, "Mouse", "Electronics"),
            new Product(103, "Monitor", "Electronics"),
            new Product(104, "Laptop", "Electronics")
        };

        var foundByName = SearchEngine.LinearSearch(products, "Monitor");
        Console.WriteLine(foundByName != null
            ? $"Linear: Found {foundByName.ProductName} in {foundByName.Category}"
            : "Linear: Product not found.");

        Array.Sort(products, (a, b) => a.ProductId.CompareTo(b.ProductId));

        var foundById = SearchEngine.BinarySearch(products, 104);
        Console.WriteLine(foundById != null
            ? $"Binary: Found {foundById.ProductName} in {foundById.Category}"
            : "Binary: Product not found.");
    }
}