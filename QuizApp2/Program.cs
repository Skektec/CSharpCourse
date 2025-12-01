namespace QuizApp2;

class Program
{
    static void Main(string[] args)
    {
        Question[] questions = new Question[]
        {
            new Question("What is the captial of Germany.", new string[] { "Johannesburg", "Berlin", "Hamburg", "Venice"}, 1),
            new Question("What is 2 + 2.", new string[] { "2", "4", "6", "8"}, 1),
            new Question("What is my favourite plane.", new string[] { "Hornet", "Typhoon", "Fulcrum", "Flanker"}, 3),
            new Question("What is the biggest ocean on Earth.", new string[] { "Caspian Sea", "Atlantic Ocean", "Pacific Ocean", "Indian Ocean"}, 2)
        };
        
        Quiz myQuiz = new Quiz(questions);
        
        myQuiz.StartQuiz();

        Console.WriteLine("Congratulations on completing the Quiz!\nYour score was: " + myQuiz.Score);
        
        Console.WriteLine("Press any key to close.");
        Console.ReadKey();
        
    }
}