using System;

namespace task_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Укажите левую границу диапазона: ");
            double a = int.Parse(Console.ReadLine());
            Console.Write("Укажите правую границу диапазона: ");
            double b = int.Parse(Console.ReadLine());

            double divider = (b - a) / 100;
            double res = 0;

            double[] lowBorders = new double[101];
            double[] upperBorders = new double[101];

            for (int i = 0; i <= lowBorders.Length - 1; i++)
            {
                lowBorders[i] = Math.Round(a + (divider * (i)), 2, MidpointRounding.AwayFromZero);
                upperBorders[i] = Math.Round(Math.Pow(Math.Log2(lowBorders[i]), 2), 2, MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < lowBorders.Length - 1 && i < upperBorders.Length + 2; i++)
            {
                res += ((upperBorders[i] + upperBorders[i + 1]) / 2) * (lowBorders[100 - i] - lowBorders[100 - (i + 1)]);
            }

            Console.WriteLine($"{ Math.Round(res, 3, MidpointRounding.AwayFromZero)}");

            // Точность расчетов проверил с помощью: https://planetcalc.ru/5494/#calculator6472
            // функция: log2(x)^2; метод трапеций.

            // как обойтись без массивов не додумался...
        }
    }
}
