using System;

namespace FourDigitNumber
{
    class FourDigitNumber
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            int inputNumber = int.Parse(Console.ReadLine());
            int a = (inputNumber / 1000) % 10, b = (inputNumber / 100) % 10, c = (inputNumber / 10) % 10, d = inputNumber % 10;
            int concatenation = a + b + c + d;
            Console.WriteLine("Sum of digits: {0}",concatenation);
            Console.WriteLine("Reversed number: {0}{1}{2}{3}",d,c,b,a);
            Console.WriteLine("Last digit becomes first: {0}{1}{2}{3}",d,a,b,c);
            Console.WriteLine("Second and third digits replaced: {0}{1}{2}{3}",a,c,b,d);
        }

    }
}
/*
 Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
Calculates the sum of the digits (in our example 2+0+1+1 = 4).
Prints on the console the number in reversed order: dcba (in our example 1102).
Puts the last digit in the first position: dabc (in our example 1201).
Exchanges the second and the third digits: acbd (in our example 2101).
The number has always exactly 4 digits and cannot start with 0. Examples:

 */