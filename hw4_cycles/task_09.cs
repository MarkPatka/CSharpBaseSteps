using System;

namespace task_09
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i < N; i++)
            {

                int Oddsum = 0;
                int Evensum = 0;
                int check_i = i;

                while (check_i > 0)
                {
                    int dights_i = check_i % 10;
                    if (dights_i % 2 == 0) Evensum += dights_i;
                    else
                        Oddsum += dights_i;

                    check_i /= 10;
                }

                if (Evensum > Oddsum) Console.WriteLine($"{i}: {Evensum}"); 

            }         
        }
    }
}
