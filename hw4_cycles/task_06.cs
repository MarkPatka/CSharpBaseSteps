using System;

namespace task_06
{
    class Program
    {
        static void Main(string[] args)
        {
            int needFind = (int)(Math.Round((Math.Pow(A, (1.0 / 3))), MidpointRounding.AwayFromZero));
            int leftEdge = 1;
            int rightEdge = A;
            int middle = ((leftEdge + rightEdge) / 2);

            if (Math.Pow(needFind, 3) != A) throw new Exception("Данное число не является кубом целого числа N");

            while (middle != needFind)
            {
                if (needFind < middle)
                {
                    rightEdge = middle;
                    middle = ((leftEdge + rightEdge) / 2);
                }
                else if (needFind > middle)
                {
                    leftEdge = middle;
                    middle = ((leftEdge + rightEdge) / 2);
                }
            }
            Console.Writeline(middle);
        }
    }
}
