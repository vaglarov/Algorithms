using System;

namespace _11.PrintNumberFrom1ToN
{
    class Program
    {
        // Write a program in C# Sharp to print the first n natural number using recursion
        static void Main(string[] args)
        {
            Console.Write("Wich number want to be last: ");
            int number = int.Parse(Console.ReadLine());
            RecusionPrintLine(0, number);
        }

        private static void RecusionPrintLine(int currentNumber, int LastNumber)
        {
            if (currentNumber== LastNumber)
            {
                Console.WriteLine(currentNumber);
                return;
            }
            Console.WriteLine(currentNumber);
            RecusionPrintLine(currentNumber+1, LastNumber);
        }
    }
}
