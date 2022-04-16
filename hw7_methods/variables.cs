using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_07
{

    class variables
    {
        public static void task01 (int a, double b)
        {
            Console.WriteLine("привет, " + a + '!');
            double c = a + b;
            Console.WriteLine(a + "+" + b + " = " + c);
            Console.WriteLine("пока, " + b + "...");
        }

        public static double task02 (double a, double b)
        {
            return (5 * a + Math.Pow(b, 4)) / (b - a);
        }

        public static string task03 (string s1, string s2)
        {
            string s3 = s1;
            s1 = s2;
            s2 = s3;
            return ($"s1 = {s1}, s2 = {s2}");
        }

        public static double task04 (double a, double b, double c)
        {
            return (c - b) / a;
        }

        public static string task05 (double x1, double y1, double x2, double y2)
        {
            double k = Math.Round((x2 - x1) / (y2 - y1), 2, MidpointRounding.AwayFromZero);
            double b = Math.Round(y1 - (k * x1), 2, MidpointRounding.AwayFromZero);
            return ($"y = {k}x + {b}");
        }

        public static int task06 (double a, double b, double c, ref double x1, ref double x2)
        {
            double D = (Math.Pow(b, 2)) - (4 * a * c);

            if (D < 0)
            {
                return 0;
            }

            if (D == 0)
            {
                x1 = Math.Round(((-1) * b) / (2 * a), 3, MidpointRounding.AwayFromZero);
                return 1;
            }
            else
            {
                x1 = Math.Round(((-1) * b + Math.Pow(D, 0.5)) / (2 * a), 3, MidpointRounding.AwayFromZero);
                x2 = Math.Round(((-1) * b - Math.Pow(D, 0.5)) / (2 * a), 3, MidpointRounding.AwayFromZero);
                return 2;
            }

        }






    }
}
