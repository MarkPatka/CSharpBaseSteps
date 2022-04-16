using System;

namespace task_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber = int.Parse(Console.ReadLine());
            int cntOdd = 0;

            while (userNumber > 0)
            {
                int checkIsOdd = userNumber % 10;

                if (checkIsOdd % 2 != 0) cntOdd++;

                userNumber /= 10;
            }

            Console.WriteLine($"{cntOdd}");
        }
    }
}
