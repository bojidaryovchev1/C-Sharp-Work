using System;

namespace ModifyBitAtPosition
{
    class ModifyBitAtPosition
    {
        static void Main()
        {
            while (true)
            {
                int numLeft, result;
                Console.Write("Value of number = ");
                int inputNumber = int.Parse(Console.ReadLine());
                Console.Write("Position: ");
                int position = int.Parse(Console.ReadLine());
                Console.Write("Value: ");
                int value = int.Parse(Console.ReadLine());
                if (value == 0 || value == 1)
                {
                    if (value == 0)
                    {
                        numLeft = ~(1 << position);
                        result = inputNumber & numLeft;
                        Console.WriteLine("Result: {0}", result);
                    }
                    if (value == 1)
                    {
                        numLeft = 1 << position;
                        result = inputNumber | numLeft;
                        Console.WriteLine("Result: {0}", result);
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect value!");
                }
            }
        }
    }
}
/*
 * We are given an integer number n, a bit value v (v=0 or 1) and a position p. 
 * Write a sequence of operators (a few lines of C# code) that modifies n to hold 
 * the value v at the position p from the binary representation of n while preserving all other bits in n.
 */