using System;
class AdvancedBitsExchange
{
    static void Main()
    {
        while (true)
        {
            uint number = 0;
            bool outOfRange = !(uint.TryParse(Console.ReadLine(), out number));
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            //validate input for out of range
            if (outOfRange == true || (p + k) > 32 || (q + k) > 32)
            {
                Console.WriteLine("out of range");
                Console.WriteLine();
                continue;
            }
            //validate input for overlaping
            if ((p < q && (p + k) >= q) || (q < p && (q + k) >= p))
            {
                Console.WriteLine("overlapping");
                Console.WriteLine();
                continue;
            }
            //init array
            int[] bitsToExchange = new int[k];
            int[] exchangeBitsWith = new int[k];
            for (int i = 0; i < k; i++)
            {
                bitsToExchange[i] = p + i;
                exchangeBitsWith[i] = q + i;
            }
            //count the array bitsToExchange
            int bitsToExchangeCount = bitsToExchange.Length;
            for (int i = 0; i < k; i++)
            {
                byte bitToExchange = getBitAtPosition(number, bitsToExchange[i]);
                byte exchangeBitWith = getBitAtPosition(number, exchangeBitsWith[i]);
                number = changeBitAtPoisiton(number, bitsToExchange[i], exchangeBitWith);
                number = changeBitAtPoisiton(number, exchangeBitsWith[i], bitToExchange);
            }
            Console.WriteLine(number);
            Console.WriteLine();
        }
    }
    static uint changeBitAtPoisiton(uint number, int position, byte bitToSet)
    {
        uint mask = (uint)(1 << position);
        uint newNumber = 0;
        if (bitToSet == 0)
        {
            newNumber = number & (~mask);
        }
        else
        {
            newNumber = number | mask;
        }
        return newNumber;
    }
    static byte getBitAtPosition(uint number, int position)
    {
        number = number >> position;
        uint mask = number & 1;
        return (byte)mask;
    }
}
/*
 * 0101 1101 p=2
 * 0001 0111
 * 0000 0001
 * 0000 0001
 */