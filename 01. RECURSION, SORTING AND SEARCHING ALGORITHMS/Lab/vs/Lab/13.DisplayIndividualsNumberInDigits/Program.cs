using System;
using System.Collections.Generic;

namespace _13.DisplayIndividualsNumberInDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int intputDigits = int.Parse(Console.ReadLine());
            Console.WriteLine();
            //Works only for digits - No sing;
            DisplayIndividualsNumberInDigits(intputDigits);
        }

        private static void DisplayIndividualsNumberInDigits(int number)
        {
            List<int> digits = new List<int>();
            digits =RecursionDisplayDigits(digits, number);
            Console.WriteLine(string.Join(" ", digits));

        }

        private static List<int> RecursionDisplayDigits(List<int> digits, int number)
        {
            if (number==0)
            {
                return digits;
            }
            int digit = Math.Abs(number) % 10;
            digits.Insert(0, digit);
            int newDigit = Math.Abs((number/10));
            RecursionDisplayDigits(digits, newDigit);
            return digits;
        }
    }
}
