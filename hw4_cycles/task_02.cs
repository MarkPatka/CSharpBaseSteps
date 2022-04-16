using System;

namespace task_02
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int i = 0;

            while (Math.Pow(i, 2) < A)
            {
                Console.WriteLine($"{i}");
                i++;
            }
        }
    }
}
