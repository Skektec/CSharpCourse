namespace QuizApp;

class Program
{
    static void Main(string[] args)
    {
        string question1 = "What is the capital of Germany?";
        string question2 = "What is 2+2?";
        string question3 = "What colour do you get by mixing blue and yellow?";

        string answer1 = "berlin";
        string answer2 = "4";
        string answer3 = "green";

        string userAnswer1;
        string userAnswer2;
        string userAnswer3;

        int points = 0;
        int attempts = 0;

        bool attemptsLeft = true;

        
        Console.WriteLine("Welcome to the Quiz\nLet the questions begin!!");

        Console.WriteLine(question1);
        userAnswer1 = Console.ReadLine().Trim().ToLower();

        while (userAnswer1 != answer1 && attemptsLeft)
        {
            Console.WriteLine("Not quite!\nTry Again!");
            attempts++;
            if (attempts >= 2) attemptsLeft = false;
            Console.WriteLine($"You've used {attempts}/3 attempts.");
            userAnswer1 = Console.ReadLine().Trim().ToLower();
        }

        if (attempts < 3 && userAnswer1 == answer1)
        {
            points = points + 3 - attempts;
            Console.WriteLine($"Awesome!\nYou got {points} points.");
        }
        
        Console.WriteLine("Next Question!");
        attempts = 0;
        attemptsLeft = true;

        Console.WriteLine(question2);
        userAnswer2 = Console.ReadLine().Trim().ToLower();

        while (userAnswer2 != answer2 && attemptsLeft)
        {
            Console.WriteLine("Not quite!\nTry Again!");
            attempts++;
            if (attempts >= 3) attemptsLeft = false;
            Console.WriteLine($"You've used {attempts}/3 attempts.");
            userAnswer2 = Console.ReadLine().Trim().ToLower();
        }

        
        if (attempts < 3 && userAnswer2 == answer2)
        {
            points = points + 3 - attempts;
            Console.WriteLine($"Good Job!\nYou got {points} points.");
        }
        
        Console.WriteLine("Next Question!");
        attempts = 0;
        attemptsLeft = true;
        
        Console.WriteLine(question3);
        userAnswer3 = Console.ReadLine().Trim().ToLower();

        while (userAnswer3 != answer3 && attemptsLeft)
        {
            Console.WriteLine("Not quite!\nTry Again!");
            attempts++;
            if (attempts >= 3) attemptsLeft = false;
            Console.WriteLine($"You've used {attempts}/3 attempts.");
            userAnswer3 = Console.ReadLine().Trim().ToLower();
        }
        
        if (attempts < 3 && userAnswer3 == answer3)
        {
            points = points + 3 - attempts;
            Console.WriteLine($"Good Job!\nYou got {points} points.");
        }

        Console.WriteLine($"Mission Complete\nYou Got {points} points.\nThanks for playing!");
        Console.ReadKey();
    }
}