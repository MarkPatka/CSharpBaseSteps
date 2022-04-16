using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays2dim
{
    internal class Task09
    {
        private static int[,] FillMins(int[,] matr, int rows, int cols)
        {
            Random rnd = new ();

            int mines_count = (int)Math.Round((rows * cols * 0.3), 0, MidpointRounding.ToZero);
            int[] rows_ind = new int[mines_count];
            int[] cols_ind = new int[mines_count];

            for (int i = 0; i < mines_count; i++)
            {
                rows_ind[i] = rnd.Next(rows - 1);
                cols_ind[i] = rnd.Next(cols - 1);
                matr[rows_ind[i], cols_ind[i]] = -1;
            }

            return matr;
        }

        public static int[,] SaperField(int rows, int cols)
        {
            int[,] matr = new int[rows, cols];

            FillMins(matr, rows, cols);
            ArrayHelper.PrintMatrix(matr);
            Console.WriteLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matr[i, j] == -1)
                    {
                        int up = i == 0 ? 0 : matr[i - 1, j] == -1 ? matr[i - 1, j] : ++matr[i - 1, j];
                        int dwn = i == rows - 1 ? 0 : matr[i + 1, j] == -1 ? matr[i + 1, j] : ++matr[i + 1, j];
                        int right = j == cols - 1 ? 0 : matr[i, j + 1] == -1 ? matr[i, j + 1] : ++matr[i, j + 1];
                        int left = j == 0 ? 0 : matr[i, j - 1] == -1 ? matr[i, j - 1] : ++matr[i, j - 1];

                        int upLeft = up == 0 ? 0 : left == 0 ? 0 : matr[i - 1, j - 1] == - 1 ? matr[i - 1, j - 1] : ++matr[i - 1, j - 1];
                        int upRight = up == 0 ? 0 : right == 0 ? 0 : matr[i - 1, j + 1] == - 1 ? matr[i - 1, j + 1] : ++matr[i - 1, j + 1];
                        int dwRigth = dwn == 0 ? 0 : right == 0 ? 0 : matr[i + 1, j + 1] == - 1 ? matr[i + 1, j + 1] : ++matr[i + 1, j + 1];
                        int dwLeft = dwn == 0 ? 0 : left == 0 ? 0 : matr[i + 1, j - 1] == -1 ? matr[i + 1, j - 1] : ++matr[i + 1, j - 1];
                    }
                }
            }

            ArrayHelper.PrintMatrix(matr);
            return matr;
        }
    }
}
