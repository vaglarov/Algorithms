using System;

namespace Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = CalcFactorial(number);
            PrintResult(result);
        }

        private static void PrintResult(long result)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(result);
            Console.ForegroundColor = ConsoleColor.White;

        }

        static int CalcFactorial(int number)
        {
            if (number == 0)
            {
                return 1;
            }
            return number * (CalcFactorial(number - 1));
        }
    }
}
