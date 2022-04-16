using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_07
{
    class branching
    {
        public static int task01(int a, int b)
        {
            int res = (a == b ? a * b : (a > b ? a + b : a - b));
            return res;
        }

        public static int task02(int x, int y)
        {
            if (x > 0 && y >= 0) return 1;
            if (x > 0 && y <= 0) return 2;
            if (x <= 0 && y > 0) return 4;
            if (x <= 0 && y < 0) return 3;
            if (x == 0 && y == 0) return 0;
            else
                return -1;

        }

        public static void task03 (int A, int B, int C, ref int A1, ref int B1, ref int C1 )
        {
            A1 = A >= B && A >= C ? A : (B >= A && B >= C ? B : C);
            B1 = (B >= A && A >= C) ^ (B <= A && A <= C) ? A :
                ((A >= B && B >= C) ^ (A <= B && B <= C) ? B : C);
            C1 = A <= B && A <= C ? A : (B <= A && B <= C ? B : C);
        }

        public static string task05 (int number)
        {
            int dozen = number / 10;
            int unit = number % 10;
            string ending = "надцать";
            string ending1 = "десят";

            Dictionary<int, string> units = new Dictionary<int, string>(10);
            units.Add(0, " ");
            units.Add(1, "Один");
            units.Add(2, "Два");
            units.Add(3, "Три");
            units.Add(4, "Четыре");
            units.Add(5, "Пять");
            units.Add(6, "Шесть");
            units.Add(7, "Семь");
            units.Add(8, "Восемь");
            units.Add(9, "Девять");


            if (dozen == 1 && unit == 0)
            {
                return "Десять";
            }
            else if (dozen == 1 && unit == 2)
            {
                return (units[2].Substring(0, units[2].Length - 1) + "e" + ending);
            }
            else if (dozen == 1 && unit == 3)
            {
                return (units[3] + ending);
            }
            else if (dozen == 1 && (unit == 1) ^ (unit >= 4))
            {
                return (units[unit].Substring(0, units[unit].Length - 1) + ending);
            }
            else if (dozen == 2 ^ dozen == 3)
            {
                return (units[dozen] + ending.Substring(2) + " " + units[unit]);
            }
            else if (dozen == 4)
            {
                return ("Сорок " + units[unit]);
            }
            else if (dozen == 5 ^ dozen == 6 ^ dozen == 7 ^ dozen == 8)
            {
                return (units[dozen] + ending1 + " " + units[unit]);
            }
            else if (dozen == 9)
            {
                return ("Девяносто " + units[unit]);
            }
            else
                return "Ошибка ввода!";
        }

        public static int task06 (int a, int b, int c)
        {
            if (((a + b > c) && (c + b > a) && (a + c > b)) && ((a > 0) && (b > 0) && c > 0)) return 1;
            else
                return -1;
        }



    }
}
