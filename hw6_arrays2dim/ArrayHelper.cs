using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays2dim
{
    static class ArrayHelper
    {
        public static int[] GenerateMas(int size, int min, int max)
        {
            int[] res = new int[size];
            Random rnd = new ();

            for (int i = min; i <= res.Length; i++)
            {
                res[i] = rnd.Next(min, max + 1);
            }
            return res;
        }

        public static int[,] GenerateMatrix(int rows, int cols, int min, int max)
        {
            int[,] res = new int[rows, cols];
            Random rnd = new ();

            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    res[i, j] = rnd.Next(min, max + 1);
                }
            }
            return res;
        }

        public static double[,] GenerateMatrix(int rows, int cols, double min, double max)
        {
            double[,] res = new double[rows, cols];
            Random rnd = new ();

            for (int i = 0; i <= res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    res[i, j] = rnd.NextDouble() * (max - min) + min;
                }
            }
            return res;
        }

        public static double[,] GenerateMatrix(int rows, int cols, double min, double max, int rounding)
        {
            double[,] res = new double[rows, cols];
            Random rnd = new ();

            for (int i = 0; i < res.GetLength(0); i++)
            {
                for (int j = 0; j < res.GetLength(1); j++)
                {
                    res[i, j] = Math.Round((rnd.NextDouble() * (max - min) + min), rounding, MidpointRounding.AwayFromZero);
                }
            }
            return res;
        }

        public static void PrintArray(double[] arr)
        {
            for (int i = 0; i != arr.Length; i++)
            {
                Console.WriteLine($"{arr[i]} ");
            }
            Console.WriteLine();
        }

        public static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        public static void PrintMatrix(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]}\t");
                }
                Console.WriteLine();
            }
        }

        public static void PrintMatrix(char[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        public static void ConsolePrint(object some1)
        {
            Console.Write($"{some1}");
        }

        public static void PrintMatrixGlue(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    ConsolePrint(matrix[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
