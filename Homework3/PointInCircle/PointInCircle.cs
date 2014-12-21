using System;
namespace PointInCircle
{
    class PointInCircle
    {
        static void Main()
        {
            while (true)
            {
                double d = 2d;
                Console.WriteLine("Coordinates:");
                Console.Write("Enter x = ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Enter y = ");
                double y = double.Parse(Console.ReadLine());
                bool expression = (Math.Pow(x, 2) + Math.Pow(y, 2)) <= Math.Pow(d, 2);
                Console.WriteLine(expression);
                Console.WriteLine();
            }

        }
    }
}
/*
 * Write an expression that checks if given point (x,  y) is inside a circle K({0, 0}, 2). Examples:
 */