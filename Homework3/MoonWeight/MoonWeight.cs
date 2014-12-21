using System;

namespace MoonWeight
{
    class MoonWeight
    {
        static void Main()
        {
            Console.Write("Enter your weight: ");
            double weight = Double.Parse(Console.ReadLine());
            double moonWeight = (17 * weight) / 100;
            Console.WriteLine("Your weight on the moon would be: {0}",moonWeight);
        }
    }
}
