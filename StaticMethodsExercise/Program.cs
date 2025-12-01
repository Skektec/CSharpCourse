namespace StaticMethodsExercise;

class Program
{
    public static int DoubleValue(int number)
    {
        return number * 2;
    }

    public static void Main(string[] args)
    {
        bool isNumber = int.TryParse(Console.ReadLine(), out int result);
        
        if (isNumber == false) 
        {
            Console.WriteLine("20");
        }
        else
        {
            int output = DoubleValue(result);
            Console.WriteLine($"{output}");
        }
    }
}