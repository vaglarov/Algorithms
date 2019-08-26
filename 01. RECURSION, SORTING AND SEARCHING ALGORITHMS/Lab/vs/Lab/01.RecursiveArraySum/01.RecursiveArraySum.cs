using System;
using System.Linq;

namespace Lab
{
    class SumArrElements
    {
        static int SumElements(int[] arr,int index)
        {
            if (index==arr.Length)
            {
                return 0;
            }
            return arr[index] + SumElements(arr, index + 1);

        }
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray(); 
           var result= SumElements(numbers,0);

            Print(result);
        }

        private static void Print(int result)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(result);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
