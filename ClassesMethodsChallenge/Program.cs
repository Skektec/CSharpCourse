namespace ClassesMethodsChallenge;

public class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person("John", 30);
        
        person.Greet();
    }
    
}

public class Person
{
    private string _name;

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    private int _age;

    public int Age
    {
        get => _age;
        set
        {
            if (value > 0)
            {
                _age = value;
            }
        }
    }

    public Person(string name, int age)
    {
        _age = age;
        _name = name;
    }

    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
}