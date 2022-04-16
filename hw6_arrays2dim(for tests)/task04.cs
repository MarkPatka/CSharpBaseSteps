using System;

namespace task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] cinema = new int[5, 6] {
                {1, 0, 1, 0, 1, 1 },
                {1, 0, 0, 0, 1, 0 },
                {0, 1, 1, 0, 1, 0 },
                {1, 0, 1, 0, 0, 1 },
                {0, 1, 0, 1, 0, 0 }};

            bool checkRule = true;
            for (int i = 0; i < cinema.GetLength(0); i++)
            {
                if (!checkRule)
                {
                    Console.WriteLine("Нарушение!");
                    break;
                }
                for (int j = 0; j < cinema.GetLength(1); j++)
                {
                    if ((j < cinema.GetLength(1) - 1) && (cinema[i, j] + cinema[i, j + 1] == 2)) checkRule = false;
                    if (!checkRule) break;
                }
            }
        }
    }
}
