namespace QuizApp2;

public class Quiz
{
    private Question[] _questions;
    private int _score;

    public int Score
    {
        get => _score;
    }

    public Quiz(Question[] questions)
    {
        this._questions = questions;
        _score = 0;
    }

    public void StartQuiz()
    {
        Console.WriteLine("Welcome to the Quiz!");

        int questionNumber = 1;

        foreach (Question question in _questions)
        {
            Console.WriteLine($"Question {questionNumber++}.");
            DisplayQuestion(question);
            int userChoice = GetUserChoice();

            if (question.IsCorrectAnswer(userChoice))
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Correct!");
                _score++;
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Wrong! The answer was: {question.CorrectAnswerIndex + 1}. {question.Answers[question.CorrectAnswerIndex]}");
                Console.ResetColor();
            }
            
        }
    }

    private void DisplayQuestion(Question question)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        
        Console.WriteLine("..........................................................................................");
        Console.WriteLine("                      " + question.QuestionText);
        Console.WriteLine("..........................................................................................");
        
        Console.ResetColor();

        for (int i = 0; i < question.Answers.Length; i++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            Console.Write("    ");
            Console.Write(i + 1);
            Console.ResetColor();
            
            Console.WriteLine($". {question.Answers[i]}");
        }
    }

    private int GetUserChoice()
    {
        Console.WriteLine("Your answer (number): ");
        string input = Console.ReadLine();
        int choice = 0;
        
        while (!int.TryParse(input, out choice) || choice <1 || choice > 4)
        {
            Console.WriteLine("Please enter a number between 1 - 4: ");
            input = Console.ReadLine();
        }

        return choice - 1; 
    }
}