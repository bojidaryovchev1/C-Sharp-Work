using System;
namespace InCircleAndOutsideRectangle
{
    class InCircleAndOutsideRectangle
    {
        static void Main()
        {
            double d = 1.5d;
            double circleX = 1d;
            double circleY = 1d;
            while (true)
            {
                Console.WriteLine("Coordinates: Check if given point is inside the circle and out of the rectangle");
                Console.Write("Value of x = ");
                double x = double.Parse(Console.ReadLine());
                Console.Write("Value of y = ");
                double y = double.Parse(Console.ReadLine());
                bool inCircle = (Math.Pow(x - circleX, 2) + Math.Pow(y - circleY, 2)) <= Math.Pow(d, 2);
                bool inRectangle = (x >= -1 && x <= 5 && y >= -1 && y <= 1);
                bool result = inCircle == true && inRectangle == false;
                if (result == true)
                {
                    Console.WriteLine("Yes, the answer is {0}",result);
                    Console.WriteLine();
                }
                else Console.WriteLine("No, the answer is {0}",result);
                Console.WriteLine();
            }
        }
    }
}
/*
 * Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) 
 * and out of the rectangle R(top=1, left=-1, width=6, height=2). 
 */