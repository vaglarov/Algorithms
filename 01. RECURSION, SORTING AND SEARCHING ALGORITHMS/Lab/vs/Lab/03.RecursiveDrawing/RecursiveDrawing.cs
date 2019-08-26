using System;

namespace _03.RecursiveDrawing
{
    class RecursiveDrawing
    {
        static void Main(string[] args)
        {
            int numberRowTriangle = int.Parse(Console.ReadLine());

            DrawTrianlgeREcusive(numberRowTriangle);
        }

        private static void DrawTrianlgeREcusive(int numberRowTriangle)
        {
            if (numberRowTriangle !=0)
            {
                Console.WriteLine(new string('*', numberRowTriangle));
                if (numberRowTriangle>1)
                {
                DrawTrianlgeREcusive(numberRowTriangle - 1);

                }
            }
            
            Console.WriteLine(new string('#', numberRowTriangle));

        }
    }
}
