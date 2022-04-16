using System;

namespace task_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrA = new int[2, 3] {
                {3, 4, 1 },
                {2, 8, 5 } };

            int[,] matrB = new int[3, 3] {
                {1, 9, 6 },
                {7, 2, 4 },
                {1, 9, 1 } };

            if (matrA.GetLength(0) != matrB.GetLength(1))
            {
                int[,] matrC = new int[matrA.GetLength(0), matrB.GetLength(1)];
                for (int i = 0; i < matrA.GetLength(0); i++)
                {
                    for (int j = 0; j < matrB.GetLength(1); j++)
                    {
                        for (int k = 0; k < matrB.GetLength(0); k++)
                        {
                            matrC[i, j] += matrA[i, k] * matrB[k, j];
                        }
                        Console.Write($"{matrC[i, j]} ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Матрицы перемножить нельзя! ");
            }
        }
    }
}
