namespace Lists3;

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>()
        {
            new Product { Name = "Apples", Price = 50.00 },
            new Product { Name = "Bananas", Price = 69.99 },
            new Product { Name = "Cherries", Price = 75.00 },
            new Product { Name = "Coconut", Price = 40.00 }
        };

        Console.WriteLine("Available Products:");

        foreach (Product item in products)
        {
            Console.WriteLine($"{item.Name} for R{item.Price}");
        }

        List<Product> cheaperProducts = products.Where(p => p.Price <= 50).ToList();
        
        Console.WriteLine("\nCheaper Products");
        
        foreach (Product item in cheaperProducts)
        {
            Console.WriteLine($"{item.Name} for R{item.Price}");
        }

        Console.ReadKey();
    }
}