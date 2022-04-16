using System;

namespace task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] matrix = new int[3, 5];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(1, 100);
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }


            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int neighborUp = (i > 0 ? matrix[i - 1, j] : 0);
                    int neighborDown = (i < matrix.GetLength(0) - 1 ? matrix[i + 1, j] : 0);
                    int neighborLeft = (j > 0 ? matrix[i, j - 1] : 0);
                    int neighborRight = (j < matrix.GetLength(1) - 1 ? matrix[i, j + 1] : 0);
                    if (matrix[i, j] > neighborUp && matrix[i, j] > neighborDown && matrix[i, j] > neighborLeft && matrix[i, j] > neighborRight)
                        count++;
                }
            }
            Console.WriteLine(count);

        }
    }
}
