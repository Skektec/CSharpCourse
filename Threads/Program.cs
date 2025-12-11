using System.Threading;

namespace Threads;

class Program
{
    static void Main(string[] args)
    {
        Thread.Sleep(1000);
        
        new Thread(() =>
        {
            Console.WriteLine("Hello, World!");
        }).Start();
        
        new Thread(() =>
        {
            Console.WriteLine("Hello, World!");
        }).Start();
        
        new Thread(() =>
        {
            Console.WriteLine("Hello, World!");
        }).Start();
        
        new Thread(() =>
        {
            Console.WriteLine("Hello, World!");
        }).Start();

        Console.ReadKey();
    }
}