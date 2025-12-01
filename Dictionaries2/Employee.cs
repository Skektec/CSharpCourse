namespace Dictionaries2;

public class Employee
{
    private string _name;
    private int _age;
    private int _salary;

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Age
    {
        get => _age;
        set => _age = value;
    }

    public int Salary
    {
        get => _salary;
        set => _salary = value;
    }

    public Employee(string name, int age, int salary)
    {
        _name = name;
        _age = age;
        _salary = salary;
    }
}