using System.ComponentModel.DataAnnotations;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(2, 4);
            int area = r.CalculateArea();
            int perimeter = r.CalculatePerimeter();
            Console.WriteLine(area + " " + perimeter);
        }
    }

    class Rectangle
    {
        public int Length { get; set; }
        public int Width { get; set; }

        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public int CalculateArea()
        {
            return Length * Width;
        }

        public int CalculatePerimeter()
        {
            return 2 * (Length + Width);
        }
    }

}