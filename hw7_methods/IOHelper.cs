using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_07
{
    static class IOHelper
    {
        public static void Divider(int len)
        {
            for (int i = 0; i < len; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

        public static void ArrIntConsOut1(int[] arr)
        {
            string str = string.Join(" ", arr);
            Console.WriteLine($"{str}");
        }

        public static void ArrIntConsOut2(int[] arr1, int[] arr2)
        {
            string str1 = string.Join(" ", arr1);
            string str2 = string.Join(" ", arr2);
            Console.WriteLine($"{str1}\n{str2}");
        }

        public static void ArrIntConsOut3(int[] arr1, int[] arr2, int[] arr3)
        {
            string str1 = string.Join(" ", arr1);
            string str2 = string.Join(" ", arr2);
            string str3 = string.Join(" ", arr3);
            Console.WriteLine($"{str1}\n{str2}\n{str3}");
        }

        public static string ArrayToStr(int[] arr)
        {
            string arr1 = string.Join(" ", arr);
            return arr1;
        }

        public static void PrintMatrix (int [,] matrix)
        {

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {

                    Console.Write($"{matrix[i, j]}\t");

                }
                Console.WriteLine();
            }

        }

        public static void ConsolePrint(object some1)
        {
            Console.Write($"{some1}");
        }
        public static void ConsolePrintLine(object some1)
        {
            Console.WriteLine($"{some1}");
        }

        public static void ConsolePrint(object some1, object some2)
        {
            Console.Write($"{some1} {some2}");
        }

        public static void ConsolePrintLine(object some1, object some2)
        {
            Console.WriteLine($"{some1} {some2}");
        }

        public static void NewLine()
        {
            Console.WriteLine();
        }
    }

}
