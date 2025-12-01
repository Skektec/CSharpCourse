namespace ClassesApp1;

class Program
{
    static void Main(string[] args)
    {
        // Car audi = new Car("Audi", "A3", true);
        // Car toyota = new Car("Toyota", "Hilux", false);
        // Car bmw = new Car("BMW", "i8", true);
        // Car hyundai = new Car("Hyundai", "H1", false);
        //
        // Console.WriteLine("Please enter the brand name.");
        // audi.Brand = Console.ReadLine();
        //
        // Console.WriteLine($"Brand is {audi.Brand}");


        Customer earl = new Customer("Earl");
        Customer frankTheTank = new Customer("FrankTheTank", "1 Main Street", "045 676 2367");
        
        Customer myCustomer = new Customer();

        Console.WriteLine($"Customer details:\nName: {myCustomer.Name}\nAddress: {myCustomer.Address}\nContact Number: {myCustomer.ContactNumber}");

        Console.WriteLine("Number of customers: " + Customer.NumOfCustomers);

    Console.ReadKey();
    }
}