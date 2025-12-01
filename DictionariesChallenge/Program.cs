namespace DictionariesChallenge;

class Program
{
    public class Exercise
    {
        public void PrintStudents()
        {
            Dictionary<string, Student> students = new Dictionary<string, Student>();
            
            students.Add("John", new Student(1, "John", 85));
            students.Add("Alice", new Student(2, "Alice", 90));
            students.Add("Bob", new Student(3, "Bob", 78));

            foreach (KeyValuePair<string, Student> student in students)
            {
                Console.WriteLine($"Name: {student.Key}, Id: {student.Value.Id}, Grade: {student.Value.Grade}");
            }
        }
    }

    public class Student
    {
        private int _id;
        private string _name;
        private int _grade;

        public int Id
        {
            get => _id;
            set => _id = value;
        }

        public string Name { get; set; } = string.Empty;

        public int Grade
        {
            get => _grade;
            set => _grade = value;
        }

        public Student(int id, string name, int grade)
        {
            _id = id;
            _name = name;
            _grade = grade;
        }
    }
}