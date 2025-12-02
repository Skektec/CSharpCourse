namespace ErrorHandlingChallenge;

class Program
{
    public void HandleMultipleExceptions(string string1, int int1)
    {
        int[] numbers = { 1, 2, 3 };

        try
        {
            int parsedInt = int.Parse(string1);

            Console.WriteLine(numbers[int1]);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid format.");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Index out of range.");
        }
    }
}