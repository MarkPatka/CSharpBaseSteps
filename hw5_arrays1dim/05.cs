using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _05
    {
            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };

            for (int j = 1; j <= 3; j++)
            {
                int last = arr[arr.Length - 1];

                for (int i = arr.Length - 1; i >= 1; i--)
                {
                    arr[i] = arr[i - 1];
                }
                arr[0] = last;
            }

            Console.WriteLine(string.Join(' ', arr));
    }
}
