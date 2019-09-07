using System;
using System.Linq;

namespace _01.PermutationsWithoutRepetitionsArray
{
    class Program
    {
        static char[] elements;
        static bool[] isUsed;
        static char[] perputations;

        static void Permute(int index)//index-current cell to fill
        {
            if (index >= elements.Length)
            {
                PrintPemutetionArray();
            }
            else
            {
                for (int i = 0; i < elements.Length; i++)
                {
                    if (!isUsed[i])
                    { 
                        var currentNumberr = elements[i];
                        isUsed[i] = true;
                        perputations[index] = currentNumberr;
                        Permute(index + 1);
                        isUsed[i] = false;
                    }
                }
            }
        }

        private static void PrintPemutetionArray()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Join(' ', perputations));
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Main(string[] args)
        {
            elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => char.Parse(x))
                .ToArray();

               
            isUsed = new bool[elements.Length];
            perputations = new char[elements.Length];

            Permute(0);
        }
    }
}
