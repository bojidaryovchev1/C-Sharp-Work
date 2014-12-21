﻿using System;
namespace ExtractBit3
{
    class ExtractBit3
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Number = ");
                int inputNumber = int.Parse(Console.ReadLine());
                int position = 3;
                int result = (inputNumber >> 3) & 1;
                Console.WriteLine("Bit at position {0}: {1}", position, Convert.ToString(result, 2));
                Console.WriteLine();
            }
        }
    }
}
/*
 * Using bitwise operators, write an expression for finding the value of the bit #3 
 * of a given unsigned integer. The bits are counted from right to left, starting from bit #0. 
 * The result of the expression should be either 1 or 0. 
 */