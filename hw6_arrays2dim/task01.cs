using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays2dim
{
    class Task01
    {
        public static int[,] ChangeSign(int rows, int cols)
        {
            int[,] matrix = ArrayHelper.GenerateMatrix(rows, cols, 10, 99);
            
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i == 0) || (j == 0) || 
                        (i == matrix.GetLength(0) - 1) || (j == matrix.GetLength(1) - 1)) 
                        matrix[i, j] *= -1;
                }
            }

            ArrayHelper.PrintMatrix(matrix);
            return matrix;
        }
      
    }
}
