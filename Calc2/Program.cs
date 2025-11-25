namespace Calc2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        double num1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        double num2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Choose an operation: +, -, *, /");
        string operation = Console.ReadLine();

        string output = "";
           
        switch (operation) {
            case "+":
                output = $"{num1 + num2}";
                break;
               
            case "-":
                output = $"{num1 - num2}";
                break;
               
            case "/":
                if (num1 == 0 || num2 == 0)
                {
                   Console.WriteLine("Error: Division by zero is not allowed.");;
                }
                else
                {
                    output = $"{num1 / num2}";
                }
               
                break;
               
            case "*":
                output = $"{num1 * num2}";
                break;
               
            default:
                Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
                break;
        }

        if (output != "")
        {
            Console.WriteLine($"Result: {output}");
        }
        
    }
}
