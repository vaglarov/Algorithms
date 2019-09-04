using System;
using System.Collections.Generic;

namespace _10.PrintNumberFromNTo1
{
    class Program
    {
        // Write a program in C# Sharp to print numbers from n to 1 using recursion.
        static void Main(string[] args)
        {
            Console.Write("Insert start number: ");
            int number = int.Parse(Console.ReadLine());
            PrintNumberRecursion(number);
            Console.WriteLine("This is our line!");
        }

        private static void PrintNumberRecursion(int number)
        {
            if (number < 0)
            {
               return;
            }
            Console.WriteLine(number);
            PrintNumberRecursion(number - 1);


        }
    }
}
