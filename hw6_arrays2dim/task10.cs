using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays2dim
{
    internal class Task10
    {
        public static char[,] ChessPieceMove(char pos1, int pos2, string piece)
        {
            char[] positions1 = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            char[] positions2 = { '1', '2', '3', '4', '5', '6', '7', '8' };
            string[] pieces = { "rook", "castle", "queen", "knight", "bishop" };
            char[,] chessField = new char[9, 9];

            for (int i = 7; i >= 0; i--)
            {
                int j = 0;
                chessField[i, j] = positions2[8 - i - 1];

            }
            for (int j = 1; j < 9; j++)
            {
                int i = 8;
                chessField[i, j] = positions1[j - 1];
            }

            if (!positions1.Contains(pos1) || !pieces.Contains(piece) || pos2 > 8 || pos2 < 1)
                throw new ArgumentException("Введены некорректные значения");

            int count = 0; 
            while (pos1 != positions1[count])
            {
                count++;
            }

            int y = pos2 - 2;
            int x = count + 1;

            chessField[x, y] = piece[0];

            switch (piece[0])
            {
                case 'b':                    
                    break;
                case 'k':
                  
                    break;
                case 'c' or 'r':
                   
                    break;
                case 'q':
                    
                    break;
            }
            ArrayHelper.PrintMatrix(chessField);
            return chessField;
        }
    }
}
