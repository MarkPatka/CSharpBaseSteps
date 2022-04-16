using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int oddCnt = 0;
            int evenCnt = 0;
            Console.WriteLine("Укажите длинну массива: ");
            int size = int.Parse(Console.ReadLine());

            Random rnd = new Random();
            int[] mas = new int[size];

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = rnd.Next(0, 101);
                if (mas[i] % 2 == 0) evenCnt++;
                else
                    oddCnt++;
            }
            Console.WriteLine(string.Join("|", mas));
            Console.WriteLine($"Четных: {evenCnt}\nНечетных: {oddCnt}");
        }
    }
}
