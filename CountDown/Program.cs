namespace CountDown;

class Program
{
    static void Main(string[] args)
    {
        for (int i = 10; i >= 0; i--)
        {
            Console.WriteLine($"{i}");
            Thread.Sleep(1000);
        }

        Console.WriteLine("Blast off!");
        Console.ReadKey();
    }
}