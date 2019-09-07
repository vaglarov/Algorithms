using System;
using System.Linq;

namespace _02.PermutationsWithoutRepetitions
{
    class Program
    {
        static char[] elements;

        static int countPermutetion = 0;

        static void Permute(int index)
        {
            if (index >= elements.Length)
            {
                PrintPemutetionArray();
            }
            else
            {
                Permute(index + 1);
                for (int i = index + 1; i < elements.Length; i++)
                {
                    Swap(index, i);
                    Permute(index + 1);
                    Swap(index, i);
                }
            }
        }

        private static void Swap(int first, int second)
        {
            var temp = elements[first];
            elements[first] = elements[second];
            elements[second] = temp;
        }

        private static void PrintPemutetionArray()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(string.Join(' ', elements));
            countPermutetion++;
            Console.ForegroundColor = ConsoleColor.White;
        }

        static void Main(string[] args)
        {
            elements = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(x => char.Parse(x))
                .ToArray();
            Permute(0);
            CheckedNumberPermutation();
        }

        private static void CheckedNumberPermutation()
        {
            Console.WriteLine($"Number print permutation: {countPermutetion}");
            int numberPermutation = Factorial(elements.Length);
            Console.WriteLine($"Calculate number of permutation: {numberPermutation}");
            if (numberPermutation == countPermutetion)
            {
                Console.WriteLine("Program work well!!");
            }
        }

        private static int Factorial(int lastElement)
        {
            if (lastElement == 1)
            {
                return 1;
            }
            else
            {
                return lastElement * Factorial(lastElement - 1);
            }
        }
    }
}
