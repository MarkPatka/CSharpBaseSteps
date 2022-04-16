using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_07
{
    class cycles
    {
        public static string task01 (int A)
        {
            string res = "";
            for (int i = 1; i < 1001; i++)
            {
                if (i % A == 0) res += i + ",";
            }
            return res;
        }

        public static string task02 (int A)
        {
            string res = " ";
            for (int i = 0; i < A / 2; i++)
            {
                if (Math.Pow(i, 2) < A) res += i + ",";
            }
            return res;
        }

        public static int task03 (int A)
        {
            int B = A / 2;
            while (A % B != 0)
            {
                B -= 1;
            }
            return B;

        }

        public static int task04 (int A, int B)
        {
            int sum = 0;
            if (A > B)
            {
                int tmp = A;
                A = B;
                B = tmp;
            }
            for (int i = A; i <= B; i += 1)
            {
                if (i % 7 == 0) sum += i;
            }
            return sum;
        }

        public static int task05 (int A, int B)
        {
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
            return A + B;
        }

        public static int task06(double A)
        {
            //if ((Math.Round(Math.Pow(A, (1.0 / 3))) != Math.Pow(A, (1.0 / 3))))
            //{
            //    throw new Exception("Введенное число не является кубом целого числа!");
            //}

            double toFind = Math.Round(Math.Pow(A, 1.0 / 3));
            double leftEdge = 1;
            double rightEdge = Math.Round(A / 2);
            double finder = Math.Round((leftEdge + rightEdge) / 2);

            while (finder != toFind)
            {
                if (finder > toFind)
                {
                    rightEdge = (leftEdge + rightEdge) / 2;
                    finder = (finder + leftEdge) / 2;
                }
                else
                {
                    leftEdge = finder;
                    finder = (finder + rightEdge) / 2;
                }

            }
            return (int)finder;
        }

        public static int task07 (int A)
        {

            int cntOdd = 0;

            while ((A > 1 && A != 0) ^ (A < -1 && A != 0))
            {
                int checkOdd = A % 10;
                if (checkOdd % 2 != 0) cntOdd++;
                A /= 10;
            }
            return cntOdd;

        }

        public static int task08 (int A)
        {

            int lengthA = A.ToString().Length;
            int res = 0;
            int cnt = 0;

            while (A > 0)
            {
                res += (A % 10) * (int)(Math.Pow(10, lengthA - cnt - 1));
                cnt++;
                A /= 10;
            }
            return res;
        }

        private static int EVorODsum (int A)
        {
            int Evensum = 0;
            int Oddsum = 0;
            int digit;

            while (A != 0)
            {
                digit = A % 10;
                if (digit % 2 != 0) Oddsum += digit;
                else
                    Evensum += digit;

                A /= 10;
            }

            if (Evensum > Oddsum) return 1;
            else
                return 0;

        }

        public static string task09 (int N)
        {
            string evens = ""; 

            for (int i = 10; i <= N; i++)
            {
                int que = EVorODsum(i);
                if (que == 1) evens += ($"|{i}|\t");
            }

            return evens;
        }

        public static string task10 (int A, int B)
        {
            if (A < 0) A *= -1;
            if (B < 0) B *= -1;

            bool answer = false;

            while (A > 0)
            {
                int dightNum1 = A % 10;
                int num2 = B;

                while (num2 > 0)
                {
                    int dightNum2 = num2 % 10;

                    if (dightNum1 == dightNum2)
                    {
                        answer = true;
                        break;
                    }
                    num2 /= 10;
                }
                if (answer == true) break;
                A /= 10;
            }
            if (answer == false) return "НЕТ";
            else
                return "ДА";
        }






    }
}
