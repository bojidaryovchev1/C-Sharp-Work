using System;
namespace CheckBitAtPosition
{
    class CheckBitAtPosition
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Number = ");
                int inputNumber = int.Parse(Console.ReadLine());
                Console.Write("Position: ");
                int position = int.Parse(Console.ReadLine());
                int result = (inputNumber >> position) & 1;
                bool resultBool;
                if (result == 1)
                {
                    resultBool = true;
                    Console.WriteLine(resultBool);
                    Console.WriteLine();
                }
                else
                {
                    resultBool = false;
                    Console.WriteLine(resultBool);
                    Console.WriteLine();
                }
            }
        }
    }
}
/*
 * Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
 * in given integer number n has value of 1. 
 */