using System;

namespace PrimeNumber
{
    class PrimeNumber
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Enter a number between 0 and 100: ");
                int inputNumber = int.Parse(Console.ReadLine());
                bool isPrime = true;
                if (inputNumber <= 100)
                {
                    if (inputNumber != 1 && inputNumber > 0)
                    {
                        for (int i = 2; i <= Math.Sqrt(inputNumber); i++)
                        {
                            if (inputNumber % i == 0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                    }
                    else isPrime = false;
                    Console.WriteLine(isPrime);
                    Console.WriteLine();
                }
                else Console.WriteLine("Incorrect value.");
                Console.WriteLine();
            }
        }
    }
}
/*
 * Write an expression that checks if given positive integer number n (n ≤ 100) is prime 
 * (i.e. it is divisible without remainder only to itself and 1). Examples:
 */