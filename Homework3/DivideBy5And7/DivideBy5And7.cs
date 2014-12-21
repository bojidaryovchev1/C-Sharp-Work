using System;
namespace DivideBy5And7
{
    class DivideBy5And7
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber % 7 == 0 && inputNumber % 5 == 0)
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false);
        }
    }
}
