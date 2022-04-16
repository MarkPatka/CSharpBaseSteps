using System;

namespace task_04_L3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Поочередно введите коэффициенты квадратного уравнения a, b и c: ");

            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Ваше уравнение: {a}x^2 + {b}x + {c} = 0");
            Console.WriteLine("Найдем дискриминант уравнения по формуле: D = b^2 - 4ac");
            double D = (Math.Pow(b, 2)) - (4 * a * c);

            if (D < 0)
            {
                Console.WriteLine($"D = {D} => корней нет");
            }
            else if (D == 0)
            {
                Console.WriteLine($"D = {D}");
                double x1 = ((-1) * b) / (2 * a);
                Console.WriteLine($"x1 = {x1}");
            }
            else
            {
                Console.WriteLine($"D = {D}");
                double x1 = Math.Round(((-1) * b + Math.Pow(D, 0.5)) / (2 * a), 3, MidpointRounding.AwayFromZero);
                double x2 = Math.Round(((-1) * b - Math.Pow(D, 0.5)) / (2 * a), 3, MidpointRounding.AwayFromZero);
                Console.WriteLine($"x1 = {x1}, x2 = {x2}.");

            }
        }
    }
}
