namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(10,5);
            Shape circle = new Circle(4);

            Console.WriteLine("Area of Rectangle: " + rectangle.CalculateArea());
            Console.WriteLine("Area of Circle: " + circle.CalculateArea());
        }

        abstract class Shape
        {
            public abstract double CalculateArea();
        }

        class Rectangle : Shape
        {
            public double Width { get; set; }
            public double Length { get; set; }

            public Rectangle(double width, double length)
            {
                Width = width;
                Length = length;
            }

            public override double CalculateArea()
            {
                return Width * Length;
            }
        }

        class Circle : Shape
        {
            public double Radius { get; set; }

            public Circle(double radius)
            {
                Radius = radius;
            }

            public override double CalculateArea()
            {
                return Math.PI * Math.Pow(Radius, 2);
            }
        }
    }
}