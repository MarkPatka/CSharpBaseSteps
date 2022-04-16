using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[10] { -1, 13, -5, 8, 0, -9, 16, 3, 0, 5 };

            for (int i = 0; i < mas.Length - 1; i++)
            {
                int min_pos = i;
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[j] < mas[min_pos]) min_pos = j;
                }
                int tmp = mas[i];
                mas[i] = mas[min_pos];
                mas[min_pos] = tmp;

            }

            Console.WriteLine(string.Join(" ", mas));
        }
    }
}
