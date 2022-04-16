using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays2dim
{
    internal class Task02
    {
        public static int[,] MultiplicationTable(int rows, int cols)
        {
            int[,] MTable = new int[rows, cols];

            for (int i = 0; i < MTable.GetLength(0); i++)
            {
                for (int j = 0; j < MTable.GetLength(1); j++)
                {
                    MTable[i, j] = (i+1) * (j+1);
                }
            }
            ArrayHelper.PrintMatrix(MTable);
            return MTable;

        }
    }
}
