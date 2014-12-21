using System;
namespace Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Length of side a = ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Length of side b = ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Height h = ");
                double h = double.Parse(Console.ReadLine());
                double area = ((a + b) / 2) * h;
                Console.WriteLine("Area: {0}", area);
                Console.WriteLine();
            }
        }
    }
}
/*
 Write an expression that calculates trapezoid's area by given sides a and b and height h. 
 */