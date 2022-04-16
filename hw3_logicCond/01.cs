using System;

namespace task_01_L3_
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b) Console.WriteLine($"{a + b}");
            else if (a == b) Console.WriteLine($"{a * b}");
            else Console.WriteLine($"{a - b}");

        }
    }
}
