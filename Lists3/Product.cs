namespace Lists3;

public class Product
{
    private string _name;
    private double _price;

    public string Name
    {
        get => _name;
        set => _name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double Price
    {
        get => _price;
        set => _price = value;
    }
}