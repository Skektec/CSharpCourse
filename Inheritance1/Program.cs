namespace Inheritance1;

public class Program
{
    static void Main(string[] args)
    {
        Dog myDog = new Dog();
        
        myDog.MakeSound();

        Console.ReadKey();
    }
}

public class Animal
{
    public virtual void MakeSound(){
        Console.WriteLine("Animal Sound");
    }
}

public class Dog : Animal
{
    public override void MakeSound(){
        base.MakeSound();
        Console.WriteLine("Dog barks");
    }
}
