using System;

public class SearchEngine
{
    public static Product LinearSearch(Product[] products, string name)
    {
        foreach (var product in products)
        {
            if (product.ProductName.Equals(name, StringComparison.OrdinalIgnoreCase))
                return product;
        }
        return null;
    }

    public static Product BinarySearch(Product[] sortedProducts, int productId)
    {
        int left = 0, right = sortedProducts.Length - 1;
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (sortedProducts[mid].ProductId == productId)
                return sortedProducts[mid];
            else if (sortedProducts[mid].ProductId < productId)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return null;
    }
}