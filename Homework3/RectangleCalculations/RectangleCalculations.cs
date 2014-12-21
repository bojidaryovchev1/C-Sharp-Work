using System;
namespace RectangleCalculations
{
    class RectangleCalculations
    {
        static void Main()
        {
            Console.Write("Enter width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Enter height: ");
            double height = double.Parse(Console.ReadLine());
            double area = width * height;
            double perimeter = width * 2 + height * 2;
            Console.WriteLine("Area: {0}",area);
            Console.WriteLine("Perimeter: {0}",perimeter);
        }
    }
}
