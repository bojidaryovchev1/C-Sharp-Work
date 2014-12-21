using System;
namespace OddOrEven
{
    class OddOrEven
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int inputNumber = int.Parse(Console.ReadLine());
            if (Math.Abs(inputNumber)% 2 == 1)
            {
                Console.WriteLine(true);
            }
            else Console.WriteLine(false);
        }
    }
}
