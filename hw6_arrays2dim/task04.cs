using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays2dim
{
    internal class Task04
    {

        public static bool AntiCovidRule(int[,] cinema)
        {
            bool checkRule = true;
            for (int i = 0; i < cinema.GetLength(0); i++)
            {
                if (!checkRule) return checkRule;
                for (int j = 0; j < cinema.GetLength(1); j++)
                {
                    if ((j < cinema.GetLength(1) - 1) && (cinema[i, j] + cinema[i, j + 1] == 2)) checkRule = false;
                    if (checkRule == false) return checkRule;
                }
            }
            return checkRule;
        }
    }
}
