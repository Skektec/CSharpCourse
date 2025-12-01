namespace ClassesApp1;

internal class Customer
{
    
    public static int NumOfCustomers;
    public string Name { get; set; }
    public string Address { get; set; }
    public string ContactNumber { get; set; }

    public Customer()
    {
        NumOfCustomers++;
        
        Name = "Default Name";
        Address = "No Address";
        ContactNumber = "No Number";
    }
        
    public Customer(string name, string address, string contactNumber)
    {        
        NumOfCustomers++;

        Name = name;
        Address = address;
        ContactNumber = contactNumber;
    }

    public Customer(string name)
    {
        NumOfCustomers++;

        Name = name;
    }
}