namespace Lists1;

class Program
{
    static void Main(string[] args)
    {
        List<string> colours = new List<string>();
        
        colours.Add("red");
        colours.Add("blue");
        colours.Add("green");

        Console.WriteLine("Colours in the colour list:");
        foreach (string colour in colours)
        {
            Console.WriteLine(colour);
        }

        colours.Remove("red");
        
        Console.WriteLine("Updated colour list:");
        foreach (string colour in colours)
        {
            Console.WriteLine(colour);
        }

        Console.ReadKey();
    }
}