namespace Dictionaries1;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, string> employees = new Dictionary<int, string>();
        
        employees.Add(365, "Matt Wallace");
        employees.Add(366, "Ben Shapiro");
        employees.Add(367, "Nick Feuntes");
        employees.Add(368, "Donald Trump");

        string name = employees[366];

        Console.WriteLine(name);

        employees[367] = "Alex Jones";

        employees.Remove(368);
        
        Console.WriteLine("Add a user.");
        Console.WriteLine("Enter the key. (367)");
        int key = int.Parse(Console.ReadLine());

        while (employees.ContainsKey(key))
        {
            key++;
        }
       
        employees.Add(key, "JD Vance");

        Console.WriteLine("JD Vance added at: " + key);  
        
        Console.WriteLine("Add a user.");
        Console.WriteLine("Enter the key. (367)");
        int key2 = int.Parse(Console.ReadLine());

        while (!employees.TryAdd(key2, "Joe Biden"))
        {
            key2++;
        }
        
        Console.WriteLine("Joe Biden added at: " + key2);  
        
        foreach (KeyValuePair<int, string> employee in employees)
        {
            Console.WriteLine($"ID: {employee.Key}, Name: {employee.Value}");
        }
        
        Console.ReadKey();
    }
}