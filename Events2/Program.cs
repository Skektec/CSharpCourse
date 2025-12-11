namespace Events2;

public delegate void StockPriceChangedHandler(string message);

public class Stock
{
    public event StockPriceChangedHandler OnStockPriceChanged;
    
    private decimal _price;
    private decimal _threshold;

    public decimal Price
    {
        set
        {
            _price = value;

            if (_price < _threshold)
            {
                RaiseStockPriceChangedEvent("Stock price is below threshold!");
            }
        } 
        
        get => _price;

    }

    public decimal Threshold
    {
        get => _threshold;
        set => _threshold = value;
    }

    protected virtual void RaiseStockPriceChangedEvent(string message)
    {
        OnStockPriceChanged?.Invoke(message);
    }
}

public class StockAlert
{
    public void OnStockPriceChanged(string message)
    {
        Console.WriteLine("Stock Alert: " + message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Stock stock = new Stock();
        StockAlert stockAlert = new StockAlert();
        
        stock.OnStockPriceChanged += stockAlert.OnStockPriceChanged;
        
        stock.Threshold = 120;

        stock.Price = 150;
        stock.Price = 130;
        stock.Price = 110;

        Console.ReadKey();
    }
}