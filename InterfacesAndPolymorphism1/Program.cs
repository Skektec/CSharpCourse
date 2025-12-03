namespace InterfacesAndPolymorphism1;

class Program
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
    
    public class PaymentService
    {
        private readonly IPaymentProcessor _processor;

        public PaymentService(IPaymentProcessor processor)
        {
            _processor = processor;
        }

        public void ProcessOrderPayment(decimal amount)
        {
            _processor.ProcessPayment(amount);
        }
    }

    public class CreditCardProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Credit card payment processed of value: " + amount);
        }
    }
    
    public class PaypalProcessor : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Paypal payment processed of value: " + amount);
        }
    }
    
    static void Main(string[] args)
    {
        IPaymentProcessor paypalPayment = new PaypalProcessor();
        PaymentService paymentService = new PaymentService(paypalPayment);
        paymentService.ProcessOrderPayment(100.00m);

        IPaymentProcessor creditCardPayment = new CreditCardProcessor();
        paymentService = new PaymentService(creditCardPayment);
        paymentService.ProcessOrderPayment(400.00m);
        
        Console.ReadKey();
    }
}