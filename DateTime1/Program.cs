namespace DateTime1;

class Program
{
    static void Main(string[] args)
    {
        int hour = DateTime.Now.Hour;
        int minute = DateTime.Now.Minute;
        int second = DateTime.Now.Second;
        
        Console.WriteLine($"It is {hour} o'clock, {minute} minutes and {second} seconds.");
        Console.ReadKey();
    }
}