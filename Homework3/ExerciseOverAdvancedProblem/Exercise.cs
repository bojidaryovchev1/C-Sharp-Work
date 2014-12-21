using System;
namespace ExerciseOverAdvancedProblem
{
    class Exercise
    {
        static void Main()
        {
            while (true)
            {
                uint inputNumber = 0;
                bool isOutOfRange = !(uint.TryParse(Console.ReadLine(), out inputNumber));
                int p, q, k;
                p = int.Parse(Console.ReadLine());
                q = int.Parse(Console.ReadLine());
                k = int.Parse(Console.ReadLine());
                if (isOutOfRange == true || (p + k) > 32 || (q + k) > 32)
                {
                    Console.WriteLine("Out of range");
                    Console.WriteLine();
                    continue;
                }
                if((p < q && (p + k) >= q) || (q < p && (q + k) >= p))
                {
                    Console.WriteLine("Overlapping");
                    Console.WriteLine();
                    continue;
                }
                int[] firstBitSequence = new int[k];
                int[] secondBitSequence = new int[k];
                for (int i = 0; i < k; i++)
                {
                    firstBitSequence[i] = p + i;
                    secondBitSequence[i] = q + i;
                }
                for (int i = 0; i < k; i++)
                {
                    byte FirstBitSequence = exportBitAtPosition(inputNumber, firstBitSequence[i]);
                    byte SecondBitSequence = exportBitAtPosition(inputNumber, secondBitSequence[i]);
                    inputNumber = changeBitAtPosition(inputNumber, firstBitSequence[i], SecondBitSequence);
                    inputNumber = changeBitAtPosition(inputNumber, secondBitSequence[i], FirstBitSequence);
                }
                Console.WriteLine("Result: {0}",inputNumber);
                Console.WriteLine();
                continue;
            }
        }
        static uint changeBitAtPosition(uint number, int position, byte value)
        {
            byte mask;
            uint changedBit;
            if(value == 0)
            {
                mask = (byte)~(1 << position);
                changedBit = number & mask;
            }
            else
            {
                mask = (byte)(1 << position);
                changedBit = number | mask;
            }
            return changedBit;
        }
        static byte exportBitAtPosition(uint number, int position)
        {
            uint exportedBit = (byte)((number >> position) & 1);
            return (byte)exportedBit;
        }
    }
}