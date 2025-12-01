namespace Lists2;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>() { 123, 20, 32, 63, 10, 2, 5, 12, 547, 12, 15};

        Console.WriteLine("Unsorted list:");

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
        
        numbers.Sort();
        
        Console.WriteLine("\nSorted list:");

        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        Console.WriteLine("\nNumbers that are 20 or greater:");

        Predicate<int> xEqlOrMoreTen = x => x >= 20;

        List<int> isGreaterThanTen = numbers.FindAll(xEqlOrMoreTen);

        foreach (int number in isGreaterThanTen)
        {
            Console.Write(number + " ");
        }

        Console.ReadKey();
    }
}