using System.Globalization;

Console.WriteLine("Enter a number");
double num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine("Enter another number");
double num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.WriteLine($"The answer of {num1.ToString(CultureInfo.InvariantCulture)} + {num2.ToString(CultureInfo.InvariantCulture)} is {Math.Round((num1 + num2), 2).ToString(CultureInfo.InvariantCulture)}");
Console.ReadKey();
