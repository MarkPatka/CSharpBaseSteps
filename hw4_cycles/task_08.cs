using System;

namespace task_08
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber = int.Parse(Console.ReadLine());
            int userNumberLength = userNumber.ToString().Length;

            int cntDights = 0;
            int userReflectNumber = 0;

            while (userNumber > 0)
            {
                userReflectNumber += (userNumber % 10) * (int)Math.Pow(10, userNumberLength - cntDights - 1);
                cntDights++;
                userNumber /= 10;
            }
            Console.WriteLine($"{userReflectNumber}");

        }
    }
}
