namespace ArrayPractice2;

class Program
{
    static void Main(string[] args)
    {
        int[,] myArray = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        int printInt = 0;

        for (int j = 0; j < 3; j++)
        {
            for (int i = 0; i < 3; i++)
            {
                printInt = printInt + myArray[j, i];
            }
            
            Console.WriteLine(printInt);
            printInt = 0;
        }
    }
}