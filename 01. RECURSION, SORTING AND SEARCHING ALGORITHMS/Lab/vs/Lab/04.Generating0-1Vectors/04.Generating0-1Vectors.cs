using System;
using System.Collections.Generic;

namespace _04.Generating0_1Vectors
{
    class Program
    {
        static void Main(string[] args)
        {
            int n =int.Parse( Console.ReadLine());
            int[] vector = new int[n];
            RecursionGenerator(0, vector);

        }

        private static void RecursionGenerator(int index, int[] vector)
        {
            if (index >= vector.Length)
                Print(vector);
            else
                for (int i = 0; i <= 1; i++)
                {
                    vector[index] = i;
                    RecursionGenerator(index + 1, vector);
                }
        }

        private static void Print(int[] listNumber)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Join(null,listNumber));
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
