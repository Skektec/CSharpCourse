namespace InterfacesAndPolymorphism4;

class Program
{
    public interface IShape
    {
        double GetArea();
    }

    public class Circle : IShape
    {
        private int _radius;
        
        public Circle(int Radius)
        {
            _radius = Radius;
            GetArea();
        }
        
        public double GetArea()
        {
            double area = Math.PI * (_radius * _radius);
            return area;
        }
    }

    public class Rectangle : IShape
    {
        private int _width;
        private int _height;
        
        public Rectangle(int Width, int Height)
        {
            _width = Width;
            _height = Height;
        }
        
        public double GetArea()
        {
            double area = _height * _width;
            return area;
        }
    }

    public class Exercise
    {
        public void PrintAreas()
        {
            IShape myCircle = new Circle(5);
            double area = myCircle.GetArea();
            Console.WriteLine($"Area: {area}");

            IShape myRectangle = new Rectangle(4,6);
            area = myRectangle.GetArea();
            Console.WriteLine($"Area: {area}");
        }
    }
}