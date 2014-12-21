using System;
namespace ExtractBitFromInt
{
    class ExtractBitFromInt
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Number = ");
                int inputNumber = int.Parse(Console.ReadLine());
                Console.Write("Position to extract: ");
                int position = int.Parse(Console.ReadLine());
                int result = (inputNumber >> position) & 1;
                Console.WriteLine("Bit at position {0}: {1}", position, Convert.ToString(result, 2));
                Console.WriteLine();
            }
        }
    }
}
/*
 Write an expression that extracts from given integer n the value of given bit at index p. 
 */