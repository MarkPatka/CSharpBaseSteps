using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _04
    {
        public static int[] Task04(int[] mas)
        {
            for (int i = 0; i < mas.Length / 2; i++)
            {
                int shift = mas.Length % 2 == 0 ? 0 : 1;
                int tmp = mas[i];
                mas[i] = mas[i + mas.Length / 2 + shift];
                mas[i + mas.Length / 2 + shift] = tmp;

            }
            return mas;
        }

    }
}
