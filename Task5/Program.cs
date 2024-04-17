using System;

namespace Task5
{
    internal class Program
    {
        public delegate double MathOperation(double x, double y);

        static double Add(double a, double b)
        {
            return a + b;
        }

        static double Subtract(double a, double b)
        {
            return a - b;
        }

        static double Multiply(double a, double b)
        {
            return a * b;
        }

        static double Divide(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Can't divide by zero!");
                return 0;
            }
        }
        static void Main(string[] args)
        {
            MathOperation mathOperation;

            mathOperation = Add;
            Console.WriteLine("Add: " + mathOperation(10, 5));

            mathOperation = Subtract;
            Console.WriteLine("Sub: " + mathOperation(10, 5));

            mathOperation = Multiply;
            Console.WriteLine("Multiplication: " + mathOperation(10, 5));

            mathOperation = Divide;
            Console.WriteLine("Division: " + mathOperation(10, 5));
        }
    }

}