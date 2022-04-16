using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_07
{
    class arraysTwoDim
    {
        public static int[,] Task01(int rows, int cols)
        {
            int[,] matrix = ArrayHelper.GenerateMatrixInt(rows, cols);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i == 0 ^ j == 0) ^ (i == 0 && j == 0) ^
                        ((i == rows - 1) && j > 0) ^ ((j == cols - 1) &&
                        (i != 0 && i != rows - 1))) matrix[i, j] *= -1;
                }
            }
            IOHelper.PrintMatrix(matrix);
            return matrix;

        }

        public static void Task02(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 2; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = i * j;
                    IOHelper.ConsolePrint($"{j}*{i}={matrix[i, j]}\t ");

                }
                IOHelper.NewLine();
            }
        }

        public static void Task03(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = 0;
                    if ((i % 2 != 0 && j % 2 != 0) ^ (i % 2 == 0 && j % 2 == 0)) matrix[i, j] = 1;

                    //Console.Write($"{matrix[i, j]} ");
                    IOHelper.ConsolePrint("", matrix[i,j]);

                }
                IOHelper.NewLine();
                
            }

        }

        public static string Task04(int[,] cinema)
        {
            bool checkRule = true;
            for (int i = 0; i < cinema.GetLength(0); i++)
            {
                if (!checkRule)
                {
                    return "Нарушение!";
                    break;
                }

                for (int j = 0; j < cinema.GetLength(1); j++)
                {
                    if ((j < cinema.GetLength(1) - 1) && (cinema[i, j] + cinema[i, j + 1] == 2)) checkRule = false;
                    if (!checkRule) break;
                }
            }
            return "Все ок!";
        }


        public static void Task05(int shops, int month, ref double sumMAX, ref double sumMIN)
        {
            double[] sumGEN = new double[shops];
            double[] sumMON = new double[shops];

            double[,] matrix = ArrayHelper.GenerateMatrixDouble(shops, month);

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Math.Round((matrix[i, j] * 10000), 2, MidpointRounding.AwayFromZero);
                    sumGEN[i] += matrix[i, j];
                    sumMON[i] += matrix[i, j] / 6;
                    sumMAX = (matrix[i, j] > sumMAX ? matrix[i, j] : sumMAX);
                    sumMIN = (matrix[i, j] < sumMIN ? matrix[i, j] : sumMIN);
                }
                IOHelper.ConsolePrintLine($"Суммарный доход {i}-й магазин:", Math.Round(sumGEN[i], 2, MidpointRounding.AwayFromZero));
                IOHelper.ConsolePrintLine($"Среднемесячный доход {i + 1}-го магазина:", Math.Round(sumMON[i], 2, MidpointRounding.AwayFromZero));


            }
            IOHelper.ConsolePrintLine($"\nНаибольший месячный доход составил: {sumMAX}\nНаименьший месячный доход составил: {sumMIN}");
        }


        public static int Task06(int[,] matrix)
        {
            ArrayHelper.PrintMatrixInt(matrix);

            int count = 0;
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
            IOHelper.ConsolePrintLine("количество элементов матрицы больших, чем их соседи: ", count);
            return count;

        }

        public static int[,] Task07(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = 1;
                    if (i > 7 - j - 1 && i < j) matrix[i, j] = 0;
                    if (i < 7 - j - 1 && i > j) matrix[i, j] = 0;
                }
            }
            ArrayHelper.PrintMatrixInt(matrix);
            return matrix;


        }

        public static int[,] Task08(int[,] matrA, int[,] matrB)
        {
            if (matrA.GetLength(1) != matrB.GetLength(0))
            {
                throw new Exception("Данные матрицы перемножить нельзя! " +
                    "Количество столбцов первой, должно быть равно количеству строк второй!");

            }

            int[,] matrC = new int[matrA.GetLength(0), matrB.GetLength(1)];
            for (int i = 0; i < matrA.GetLength(0); i++)
            {
                for (int j = 0; j < matrB.GetLength(1); j++)
                {
                    for (int k = 0; k < matrB.GetLength(0); k++)
                    {
                        matrC[i, j] += matrA[i, k] * matrB[k, j];
                    }
                }
            }
            IOHelper.ConsolePrintLine("Результат matrA * matrB = ");
            ArrayHelper.PrintMatrixInt(matrC);
            return matrC;
        }
    }
}
