using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_07
{
    class mathExpressions
    {
        public static int task01 (int num = 259)
        {
            int res = (num / 100) + ((num / 10) % 10) + (num % 10);
            return res;
        }

        public static string task02 (double x, double y, double R)
        {
            if ((Math.Pow(x, 2) + Math.Pow(y, 2)) < Math.Pow(R, 2)) return "Попадание!";
            else
                return "Промах!";
        }    

        public static int task03 (int num)
        {
            if ((((num / 10) % 10) <= num / 100) && (((num / 10) % 10) > num % 10)) return 1;
            else
                return 0;
        }

        public static int task04 (int number)
        {
            int number1 = ((number % 10) * 100) + (((number / 10) % 10) * 10) + (number / 100);
            return number1;
        }

        public static string task05 (double number)
        {
            int a = (int)number;
            return ($"{number}:{number == a}");
        }

    }
}
