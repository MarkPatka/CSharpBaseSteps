using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class _03
    {
	    int[] arr1 = new int[] { 5, 8, 2, 4, 1, 4 };
            int[] arr2 = new int[] { 9, 4, 2, 4, 7, 2, 1, 3, 5 };
            int[] arr3 = new int[arr1.Length + arr2.Length];

            for (int i = 0; i < arr1.Length; i++)
            {
                arr3[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr3[arr1.Length + i] = arr2[i];
            }
	

    }
}
