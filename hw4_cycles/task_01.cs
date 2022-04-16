using System;

namespace task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());

            for (int i = 1; i < 1001; i++)
            {
                if (i % A == 0) Console.WriteLine(i);

            }
        }
    }
}
