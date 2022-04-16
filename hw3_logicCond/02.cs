using System;

namespace task_02_L3_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите поочередно координату X, затем Y");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());

            if (x == 0 && y == 0) Console.WriteLine("Начало координат");
            else if (x == 0 && y < 0) Console.WriteLine("Точка принадлежит оси ординат (0 ; inf)");
            else if (x == 0 && y > 0) Console.WriteLine("Точка принадлежит оси ординат (0 ; sup)");
            else if (y == 0 && x > 0) Console.WriteLine("Точка принадлежит оси абсцисс (0 ; sup)");
            else if (y == 0 && x < 0) Console.WriteLine("Точка принадлежит оси абсцисс (0 ; inf)");

            else if (x > 0)
                if (y > 0) Console.WriteLine("Первая четверть");
                else Console.WriteLine("Вторая четверть");
            else if (x < 0)
                if (y < 0) Console.WriteLine("Третья четверть");
                else Console.WriteLine("Четвертая четверть");

        }
    }
}
