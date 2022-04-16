using System;


//4) Пользователь вводит два числа (A и B). 
//    Вывести сумму всех чисел из диапазона от A до B, 
//    которые делятся без остатка на 7. 
//    (Учтите, что при вводе B может оказаться меньше A).

namespace task_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());
            int sum = 0;

            if (A > B)
            {
                int tmp = A;
                A = B;
                B = tmp;
            }

            for (int i = A; i < B; i += 1)
            {
                if (i % 7 == 0) sum += i;

            }
            Console.WriteLine($"{sum}");
        }
    }
}
