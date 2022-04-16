using System;

//5) Пользователь вводит два числа. 
//    Найти их наибольший общий делитель используя алгоритм Евклида.


namespace task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            while (A != 0 && B != 0)
            {
                if (A > B)
                {
                    A %= B;
                }
                else
                {
                    B %= A;
                }

            }

            Console.WriteLine($"{A + B}");
        }
    }
}
