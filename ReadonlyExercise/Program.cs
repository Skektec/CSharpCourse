namespace ReadonlyExercise;

class Program
{
    public class MyClass
    {
        private readonly string _myString;
        public string MyString
        {
            get => _myString;
        }
        

        public MyClass(string value)
        {
            _myString = value;
        }
    }

    public class Exercise
    {
        public void PrintReadOnlyProperty()
        {
            MyClass myClass = new MyClass("Read-Only Property Value");

            Console.WriteLine(myClass.MyString);
        }
    }
}