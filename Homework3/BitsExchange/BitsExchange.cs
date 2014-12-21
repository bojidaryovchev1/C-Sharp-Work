using System;

namespace BitsExchange
{
    class BitsExchange
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            uint inputNumber = uint.Parse(Console.ReadLine());
            uint firstBits = inputNumber >> 3;
            uint secondBits = inputNumber >> 24;
            uint firstBitsClean = firstBits & 7;
            uint secondBitsClean = secondBits & 7;
            uint firstBitsMask = 7 << 3;
            uint secondBitsMask = 7 << 24;
            uint firstBitsLeft = firstBitsClean << 24;
            uint secondBitsLeft = secondBitsClean << 3;
            uint inputFirstMask = inputNumber & ~firstBitsMask;
            uint inputSecondMask = inputNumber & ~secondBitsMask;
            inputNumber = inputFirstMask | secondBitsLeft;
            inputNumber = inputSecondMask | firstBitsLeft;
            Console.WriteLine("Result(decimal): {0}", inputNumber);
        }
    }
}
/***************************************************Logics********************************************************
 * We take the given integer's default binary code and we make 2 variables, which move its
 * binary representation to the right(in our case, we need to replace bits 3,4,5 with 24,25,26)
 * So we need to get the digits into positions 0,1,2,..z(at the right side of the binary code)
 * In our case we do it by moving our number once 3 positions and once 24 positions
 * When the digits take their position its time to clean up by removing all other digits except the needed ones
 * Here is an example: 0000 0000 0000 0000 0000 0000 0100 0100 -> 0000 0000 0000 0000 0000 0000 0000 0100
 * After we're done with these operations, we need to move our digits to their required positions
 * To do that, we take our cleansed representation and again we store it into 2 variables,
 * moving it once 24 times and once 3 times. You must regard that here we need to do it counter,
 * because we need to exchange the values. 
 * Example: uint firstBitsLeft = firstBitsClean << 24, secondBitsLeft = secondBitsClean << 3;
 * The next step is to take the binary representation of the entered integer and concatenate it
 * with the opposite value of 1,3,7,15,31...,z(binary), moved left once 3 times and once 24 times, using
 * &, | or ^ operators.And ofcourse ~ for opposite value.
 * Example: uint mask1 = 7 << 3, mask2 = 7 << 24;
 *          uint inputMask1 = inputNumber & ~mask1, inputMask2 = inputNumber & ~mask2;
 * Finally, we need to declare our final 2 variables, which must contain once 1 with 2 and once 2 with 1.
 * Example: inputNumber = inputMask1 | secondBitsLeft;
            inputNumber = inputMask2 | firstBitsLeft;
 * Export the result to the console(integer) and we're done.
 */
/*
 * BITS EXCHANGE: EXAMPLES
 * 0100 0(100) 0000 0000 0100 0000 00(010)101
 * 01000(010) 00000000 01000000 00(10 0)101
 *          inputNumber = inputFirstMask | (secondBits << 3);
 *          inputNumber = inputSecondMask | (firstBits << 24);
 *          uint firstBits = (n >> 3) & 7;
 *          uint secondBits = (n >> 24) & 7;
 * 0000 0000 0000 0000 0000 0000 0000 0100 secondBitsClean
 * 0000 0000 0000 0000 0000 0000 0000 0010 firstBitsClean
 * 0000 0111 0000 0000 0000 0000 0000 0000 secondBitsMask
 * 0000 0000 0000 0000 0000 0000 0011 1000 firstBitsMask
 * 1111 1000 1111 1111 1111 1111 1111 1111 ~secondBitsMask
 * 0100 0100 0000 0000 0100 0000 0001 0101 INPUT
 * 1111 1111 1111 1111 1111 1111 1100 0111 ~firstBitsMask
 * 0100 0100 0000 0000 0100 0000 0001 0101 INPUT
 * 0000 0000 0000 0000 0000 0000 0010 0000 secondBitsClean << 3
 * 0000 0010 0000 0000 0000 0000 0000 0000 firstBitsClean << 24
 * 0100 0100 0000 0000 0100 0000 0000 0101 INPUT & ~firstBitsMask = inputFirstMask
 * 0100 0000 0000 0000 0100 0000 0001 0101 INPUT & ~secondBitsMask = inputSecondMask
 * 0100 0100 0000 0000 0100 0000 0010 0101 exchange happens here
 * 0100 0010 0000 0000 0100 0000 0001 0101 exchange happens here also; final result
 */