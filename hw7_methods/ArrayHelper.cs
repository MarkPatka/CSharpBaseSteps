using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_07
{
    static class ArrayHelper
    {
        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        public static void PrintArray(double[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }
            Console.WriteLine();
        }

        public static int[] GenerateArrayInt(int size, int min, int max)
        {
            int[] res = new int[size];
            Random rnd = new Random();
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = rnd.Next(min, max + 1);
            }
            return res;
        }

        public static double[] GenerateArrayDouble(int size, double min, double max)
        {
            double[] res = new double[size];
            Random rnd = new Random();
            for (int i = 0; i < res.Length; i++)
            {
                res[i] = rnd.NextDouble() * (max - min) + min;
            }
            return res;
        }


        public static void swap(ref int a, ref int b)
        {
            int tmp;
            tmp = a;
            a = b;
            b = tmp;
        }

        public static int[,] GenerateMatrixInt(int rows, int cols)
        {
            Random rnd = new Random();
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(10, 101);
                }
            }
            return matrix;
        }

        public static double[,] GenerateMatrixDouble(int rows, int cols)
        {
            Random rnd = new Random();
            double[,] matrix = new double[rows, cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = rnd.Next(0, 1000);
                }
            }
            return matrix;
        }

        public static void PrintMatrixInt (int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    IOHelper.ConsolePrint(matrix[i, j], "\t");
                }
                IOHelper.NewLine();
            }

        }

        public static void PrintMatrixIntGlue (int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    IOHelper.ConsolePrint(matrix[i, j]);
                }
                IOHelper.NewLine();
            }

        }

    }
}
