namespace Interface1;

class Program
{
    private interface IAnimal
    {
        void MakeSound();
        void Eat(string food);
    }
    
    private class Dog : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("A dog barks");
        }

        public void Eat(string food)
        {
            Console.WriteLine("A dog eats " + food);
        }
    }
    
    private class Cat : IAnimal
    {
        public void MakeSound()
        {
            Console.WriteLine("A cat meows");
        }

        public void Eat(string food)
        {
            Console.WriteLine("A cat eats " + food);
        }
    }
    
    
    static void Main(string[] args)
    {
        Cat myCat = new Cat();
        Dog myDog = new Dog();
        
        myCat.MakeSound();
        myCat.Eat("fish");
        
        myDog.MakeSound();
        myDog.Eat("kibble");

        Console.ReadKey();
    }
}