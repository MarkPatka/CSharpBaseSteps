using System;

namespace task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows, cols;
            Console.WriteLine("Количество строк: ");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество столбцов: ");
            cols = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 101);

                    if ((i == 0 ^ j == 0) ^ (i == 0 && j == 0) ^
                        ((i == rows - 1) && j > 0) ^ ((j == cols - 1) &&
                        (i != 0 && i != rows - 1))) matrix[i, j] *= -1;
                    Console.Write($"{matrix[i, j]}\t");

                }
                Console.WriteLine();
            }
        }
    }
}
