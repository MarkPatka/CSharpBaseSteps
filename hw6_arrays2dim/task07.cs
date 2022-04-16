using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays2dim
{
    internal class Task07
    {
        public static int[,] HourGlassMatrix(int rows, int cols)
        {
            int[,] arr = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    arr[i, j] = 1;
                    if (i < (cols - 1) - j && i > j) arr[i, j] = 0;
                    if (i > (cols - 1) - j && i < j) arr[i, j] = 0;
                }
            }
            ArrayHelper.PrintMatrix(arr);
            return arr;

        }
    }
}
