using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays2dim
{
    internal class Task06
    {
        public static int BiggestElementsAmongNighbours(int[,] arr)
        {
            int count = 0;

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    int neighbourUp = i > 0 ? arr[i - 1, j] : 0;
                    int neighbourRight = j < arr.GetLength(1) - 1 ? arr[i, j + 1] : 0;
                    int neighbourDown = i < arr.GetLength(0) - 1 ? arr[i + 1, j] : 0;
                    int neighbourLeft = j > 0 ? arr[i, j - 1] : 0;

                    if (arr[i, j] > neighbourUp && arr[i, j] > neighbourDown && arr[i, j] > neighbourLeft && arr[i, j] > neighbourRight) count++;

                }
            }
            Console.WriteLine(count);
            return count;
        }
    }
}
