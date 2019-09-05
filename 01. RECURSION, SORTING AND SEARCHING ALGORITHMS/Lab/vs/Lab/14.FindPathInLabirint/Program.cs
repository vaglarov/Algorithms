using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.FindPathInLabirint
{
    class Program
    {
        private static char[,] labirint;

        private static List<char> resultPath = new List<char>();
        static void Main(string[] args)
        {
            ReadInput();
            Solve(0, 0,'S');
           // PrintMatrix();

        }

        private static void Solve(int row, int col,char direction)
        {
            if (OutSideOfLabirint(row, col))
            {
                return;
            }
            resultPath.Add(direction);
            if (ExitTheLabirint(row, col))
            {
                PrintSolutin();
            }

            if (IsPassable(row, col))
            {
                labirint[row, col] = 'x';

                Solve(row, col - 1,'L');//Left
                Solve(row, col + 1,'R');//Right
                Solve(row - 1, col,'U');//Up
                Solve(row + 1, col,'D');//Down
                labirint[row, col] = '-';
            }
            resultPath.RemoveAt(resultPath.Count-1);
        }

        private static void PrintSolutin()
        {
            Console.WriteLine(string.Join(string.Empty,resultPath.Skip(1)));
        }

        private static bool IsPassable(int newRow, int newCol)
        {
            if (labirint[newRow,newCol]=='-')
            {
                return true;
            }
            return false;
        }

        private static bool ExitTheLabirint(int newRow, int newCol)
        {
            return labirint[newRow, newCol] == 'e';
        }

        private static bool OutSideOfLabirint(int newRowPosition, int newColPosition)
        {
            if (newRowPosition < 0 || newRowPosition >= labirint.GetLength(0))
            {
                return true;
            }
            if (newColPosition < 0 || newColPosition >= labirint.GetLength(1))
            {
                return true;
            }
            return false;
        }

        private static void PrintMatrix()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int row = 0; row < labirint.GetLength(0); row++)
            {
                for (int col = 0; col < labirint.GetLength(1); col++)
                {
                    Console.Write(labirint[row, col]);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void ReadInput()
        {
            int row = int.Parse(Console.ReadLine());
            int col = int.Parse(Console.ReadLine());
            labirint = new char[row, col];
            for (int rowLabirint = 0; rowLabirint < labirint.GetLength(0); rowLabirint++)
            {
                char[] currentRow = Console.ReadLine().ToCharArray();
                for (int colLabirint = 0; colLabirint < labirint.GetLength(1); colLabirint++)
                {
                    labirint[rowLabirint, colLabirint] = currentRow[colLabirint];
                }
            }
        }
    }
}
