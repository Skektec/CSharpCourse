namespace GuessTheNumber;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        int randomNumber = random.Next(1, 11);
        int guess = 0;

        Console.WriteLine("Hello there!\nGuess a number between 1-10!!");

        while (guess != randomNumber)
        {
            int.TryParse(Console.ReadLine(), out guess);

            if (guess != randomNumber)
            {
                Console.WriteLine("Try again!");
            }
        }
        
        Console.WriteLine("Yayyy, well done!");
        Console.ReadKey();
    }
}