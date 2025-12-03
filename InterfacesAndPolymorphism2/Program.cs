namespace InterfacesAndPolymorphism2;

public interface IPayment
{
    void ProcessPayment();
}

public class CreditCardPayment : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing credit card payment");
    }
}

public class PayPalPayment : IPayment
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing PayPal payment");
    }
}

public class Exercise
{
    public void ProcessPayments()
    {
        PayPalPayment myPayPalPayment = new PayPalPayment();
        CreditCardPayment myCreditCardPayment = new CreditCardPayment();
        
        myCreditCardPayment.ProcessPayment();
        myPayPalPayment.ProcessPayment();
    }
}