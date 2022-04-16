using System;

namespace task_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = A / 2;

            while (A % B != 0)
            {
                B -= 1;
            }
            Console.WriteLine($"{B}");
        }
    }
}
