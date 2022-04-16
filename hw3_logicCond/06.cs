using System;

namespace task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a + b > c)
            {
                if (c + b > a)
                {
                    if (a + c > b)
                    {
                        Console.WriteLine("Треугольник существует");
                    }
                }
            }
            else
            {
                Console.WriteLine("Треугольника не существует");
            }
        }
    }
}
