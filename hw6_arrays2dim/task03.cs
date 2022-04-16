using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays2dim
{
    internal class Task03
    {
        public static int[,] ChessLikeOrder(int rows, int cols)
        {
            int[,] ChessDeck = new int[rows, cols];
            bool ISRowsEven = rows % 2 == 0;

            for (int i = rows - 1; i >= 0; i--)
            {
                bool IsRowEven = i % 2 == 0;

                for (int j = 0; j < ChessDeck.GetLength(1); j += 2)
                {
                    if (ISRowsEven == true)
                        if (IsRowEven == false && j <= cols - 1) ChessDeck[i, j + 1] = 1;
                        else
                            ChessDeck[i, j] = 1;
                    else
                        if (IsRowEven == true) ChessDeck[i, j] = 1;
                        else if (j >= 0 && j <= cols - 2) ChessDeck[i, j + 1] = 1;

                }
            }
            ArrayHelper.PrintMatrix(ChessDeck);
            return ChessDeck;
        }
    }
}
