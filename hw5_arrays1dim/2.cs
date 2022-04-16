using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Какого размера массив? ");
            int size = Convert.ToInt32(Console.ReadLine());

            Random rnd = new Random();
            int[] mas = new int[size];
            int sumprev = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(0, 101);
            }
            Console.WriteLine($"Исходный массив: {string.Join(" ", mas)}");

            for (int i = 2; i < mas.Length; i += 3)
            {
                mas[i] = 0;
                sumprev = mas[i - 2] + mas[i - 1];
                mas[i] = sumprev;
            }
            Console.WriteLine($"Измененный массив: {string.Join(" ", mas)}");
        }
    }
}
