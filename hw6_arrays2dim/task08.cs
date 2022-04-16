using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays2dim
{
    internal class Task08
    {
        public static double[,] MatrixMultiplication(double[,] arrA, double[,] arrB)
        {
            if (arrA.GetLength(1) != arrB.GetLength(0)) throw new ArgumentException("Данные матрицы перемножить нельзя!");

            double[,] arrC = new double[arrA.GetLength(0), arrB.GetLength(1)];

            for (int i = 0; i < arrA.GetLength(0); i++)
            {
                for (int j = 0; j < arrB.GetLength(1); j++)
                {
                    for (int k = 0; k < arrB.GetLength(0); k++)
                    {
                        arrC[i, j] += arrA[i, k] * arrB[k, j]; 
                    }
                }
            }
            ArrayHelper.PrintMatrix(arrC);
            return arrC;
        }
    }
}
