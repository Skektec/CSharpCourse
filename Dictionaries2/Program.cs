namespace Dictionaries2;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, Employee> employees = new Dictionary<int, Employee>();
        
        employees.Add(1, new Employee("Matt Wallace", 34, 120000));
        employees.Add(2, new Employee("Ben Shapiro", 40, 13000));
        employees.Add(3, new Employee("Nick Fuentes", 29, 150000));
        employees.Add(4, new Employee("Alex Jones", 60, 15000));
        employees.Add(5, new Employee("Donald Trump", 84, 10000));
        employees.Add(6, new Employee("Charlie Kirk", 44, 180000));

        foreach (KeyValuePair<int, Employee> employee in employees)
        {
            Console.WriteLine($"Employee Number: {employee.Key}\nName: {employee.Value.Name}, Age: {employee.Value.Age}, Salary: {employee.Value.Salary}");
        }
        
        Console.ReadKey();
    }
}