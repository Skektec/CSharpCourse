using Inheritance2;

namespace Inheritance2;

public class Person
{
    public string Name;
    public Person(string name)
    {
        Name = name;
    }
    
    public virtual void printInfo()
    {   
        Console.WriteLine($"Person constructor: {Name}");
    }
}

public class Employee : Person
{
    public string Name;
    public int Id;
    
    public Employee(string name, int id) : base(name)
    {
        Name = name;
        Id = id;
    }
    
    public override void printInfo()
    {
        base.printInfo();
        Console.WriteLine($"Employee constructor: {Name}, ID: {Id}");
    }
}

public class Exercise
{
    public void PrintMessages()
    {
        Employee newEmployee = new Employee("John Doe", 123);
        
        newEmployee.printInfo();
    }
}