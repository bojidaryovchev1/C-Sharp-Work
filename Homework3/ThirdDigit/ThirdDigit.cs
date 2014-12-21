using System;
namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main()
        {
            Console.Write("Please enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int thirdDigit = (number / 100) % 10;
            if (thirdDigit == 7)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
