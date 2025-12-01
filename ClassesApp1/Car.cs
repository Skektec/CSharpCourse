namespace ClassesApp1;

internal class Car
{
    private string _brand = "";
    private string _model = "";
    private bool _luxVarient;
    
    public string Brand
    {
        get => _brand;
        set => _brand = value;
    }

    public string Model
    {
        get
        {
            if (_luxVarient == true)
            {
                return $"{_model} - Luxury Variant";
            }
            else
            {
                return _model;
            }
        }
        set{
            if (string.IsNullOrEmpty(value))
            {
                Console.WriteLine("Invalid Inputs.");
                _brand = "DEFAULTVALUE";
            }
            else
            {
                _brand = value;
            }
            
        }
    }
    
    public Car(string brand, string model, bool luxVarient)
    {
        
        _luxVarient = luxVarient;
        Brand = brand;
        Model = model;
        Console.WriteLine($"An object of Car '{Brand} {Model}' has been created.");
    }
}