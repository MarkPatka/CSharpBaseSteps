using System;

namespace task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение x, функции сos(x)");
            double x = Double.Parse(Console.ReadLine());
            Console.WriteLine("До которого периода хотите произвести расчет: ");
            int n = int.Parse(Console.ReadLine());

            double res = 1;

            for (int i = 1; i <= n; i++)
            {
                int sign = -1;
                if (i % 2 == 0) sign = 1;

                int fact = 1;
                fact *= i;

                Console.WriteLine($"{i}-й член ряда = {res}");
                res = sign * (Math.Pow(x, (2 * i)) / (2 * fact));
            }
        }
    }
}
