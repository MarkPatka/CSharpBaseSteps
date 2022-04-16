using System;

namespace task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             * 1) y = -3
             * 2) y = x +3
             * 3) y = sqrt(r-x)(r+x)
             * 4) y = |x - 3|
             */

            Console.WriteLine("Укажите значение X, чтобы получить значение заданной функции в данной точке: ");
            double x = Double.Parse(Console.ReadLine());

            if ((x < -7) ^ (x > 6))
            {
                Console.WriteLine("На данном промежутке функция не определена.\nФункция определена на промежутке [-7;6]");
            }
            else if (x >= -7 && x < -6)
            {
                Console.WriteLine("y = -3");
            }
            else if (x >= -6 && x < -3)
            {
                double y = x + 3;
                Console.WriteLine($"y = {y}");
            }
            else if (x >= -3 && x < 0)
            {
                double y = Math.Sqrt((3 - x) * (3 + x));
                Console.WriteLine($"y = {y}");
            }
            else if (x >= 0 && x < 3)
            {
                double y = -x + 3;
                Console.WriteLine($"y = {y}");
            }
            else if (x >= 3 && x <= 6)
            {
                double y = x - 3;
                Console.WriteLine($"y = {y}");
            }

        }
    }
}
