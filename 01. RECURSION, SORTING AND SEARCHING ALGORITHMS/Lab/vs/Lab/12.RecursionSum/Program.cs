using System;

namespace _12.RecursionSum
{
    //Write a program in C# Sharp to find the sum of first n natural numbers using recursion. Go to the 
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int result = SumRecursion(number);
            Console.WriteLine(result);
        }

        private static int SumRecursion(int number)
        {

            int sum;
            if (number == 0)
            {
                return 0;
            }
            sum = number + SumRecursion(number - 1);

            return sum;
        }
    }
}
