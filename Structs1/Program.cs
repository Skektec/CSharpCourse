namespace Structs1;

class Program
{
    public struct myStruct
    {
        public double point1X { get; }
        public double point1Y { get; }
        
        public double point2X { get; }
        public double point2Y { get; }

        public myStruct(double Point1X, double Point1Y, double Point2X, double Point2Y)
        {
            point1X = Point1X;
            point1Y = Point1Y;

            point2X = Point2X;
            point2Y = Point2Y;
        }

        public double getDistance()
        {
            double distance = Math.Sqrt(Math.Pow((point2X - point1X), 2) + Math.Pow((point2Y - point1Y), 2));
            return distance;
        }
    }
    
    static void Main(string[] args)
    {

        bool doubleAns = false;
        
        double p1X = 0;
        double p1Y = 0;
        double p2X = 0;
        double p2Y = 0;
        
        Console.WriteLine("Enter 4 points to get their distance.");
        
        Console.WriteLine("Point 1 X:");

        while (!doubleAns)
        {
            doubleAns = double.TryParse(Console.ReadLine(), out p1X);

            if (doubleAns == false)
            {
                Console.WriteLine("Enter a valid number.");
            }
        }
        
        doubleAns = false;
        
        Console.WriteLine("Point 1 Y:");
        
        
        while (!doubleAns)
        {
            doubleAns = double.TryParse(Console.ReadLine(), out p1Y);

            if (doubleAns == false)
            {
                Console.WriteLine("Enter a valid number.");
            }
        }
        
        doubleAns = false;
        
        Console.WriteLine("Point 2 X:");
        
        while (!doubleAns)
        {
            doubleAns = double.TryParse(Console.ReadLine(), out p2X);

            if (doubleAns == false)
            {
                Console.WriteLine("Enter a valid number.");
            }
        }
        
        doubleAns = false;
        
        Console.WriteLine("Point 2 Y:");
        
        while (!doubleAns)
        {
            doubleAns = double.TryParse(Console.ReadLine(), out p2Y);

            if (doubleAns == false)
            {
                Console.WriteLine("Enter a valid number.");
            }
        }

        myStruct calcDistance = new myStruct(p1X, p1Y, p2X, p2Y);
        double distance = calcDistance.getDistance();
        Console.WriteLine("The distance between those two points is: " + distance);
        Console.ReadLine();

    }
}