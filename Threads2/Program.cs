namespace Threads2;

class Program
{
    static void Main(string[] args)
    {
        Enumerable.Range(0, 1000).ToList().ForEach(f =>
        {
            ThreadPool.QueueUserWorkItem((o) =>
            {
                Console.WriteLine($"Thread Number: {Thread.CurrentThread.ManagedThreadId} started.");
                Thread.Sleep(1000);
                
                Console.WriteLine($"Thread Number: {Thread.CurrentThread.ManagedThreadId} ended.");
            });
        });
        
        Console.ReadKey();
    }
}