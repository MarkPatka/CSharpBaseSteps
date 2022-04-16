using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[10] { -1, 13, -5, 8, 0, -9, 16, 3, 0, 5 };

            for (int i = 1; i < mas.Length; i++)
            {
                int elem = mas[i];
                int j = i;
                while (j > 0 && elem < mas[j - 1])
                {
                    mas[j] = mas[j - 1];
                    j--;
                }
                mas[j] = elem;
            }
            Console.WriteLine(string.Join(" ", mas));
        }
    }
}
