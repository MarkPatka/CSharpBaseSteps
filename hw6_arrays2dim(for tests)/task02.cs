using System;

namespace task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[10, 10];

            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 2; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i * j;
                    Console.Write($"{j}*{i}={matrix[i, j]}\t ");

                }
                Console.WriteLine();
            }
        }
    }
}
