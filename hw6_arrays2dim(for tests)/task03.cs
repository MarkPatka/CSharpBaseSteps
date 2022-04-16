using System;

namespace task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = 8;
            int cols = 8;
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = 0;
                    if ((i % 2 != 0 && j % 2 != 0) ^ (i % 2 == 0 && j % 2 == 0)) matrix[i, j] = 1;

                    Console.Write($"{matrix[i, j]} ");

                }

                Console.WriteLine($"|{i + 1}");
            }
            Console.Write("---------------\nA B C D E F G H");
        }
    }
}
