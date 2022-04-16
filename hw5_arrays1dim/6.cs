using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину массива: ");
            int size = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int[] mas = new int[size];

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(0, 101);
            }
            Console.WriteLine($"\nИсходный массив: {string.Join(" ", mas)}");

            int cnt = 0;

            for (int i = mas.Length - 1; i >= 0; i -= 2)
            {
                if (i == 0) break;

                int tmp = mas[i];
                mas[i] = mas[i - 1];
                mas[i - 1] = tmp;
                cnt++;
            }
            Console.WriteLine($"\nПолученный массив: {string.Join(" ", mas)}\nЧисло операций: {cnt}");
        }
    }
}
