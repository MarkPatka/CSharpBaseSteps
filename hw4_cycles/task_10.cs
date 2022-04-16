using System;

namespace task_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber1 = int.Parse(Console.ReadLine());
            int userNumber2 = int.Parse(Console.ReadLine());

            bool answer = false;

            while (userNumber1 > 0)
            {
                int dightNum1 = userNumber1 % 10;
                int num2 = userNumber2;
                while (num2 > 0)
                {
                    int dightNum2 = num2 % 10;
                    if (dightNum1 == dightNum2)
                    {
                        Console.WriteLine("Yes!");
                        answer = true;
                        break;
                    }
                    num2 /= 10;
                }
                if (answer == true) break;
                userNumber1 /= 10;
            }
            if (answer == false) Console.WriteLine("No!");
        }
    }
}
