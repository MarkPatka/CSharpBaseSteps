using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
        	public static int[] Task07 (int[] mas)
        	{
            		int min = mas[0];
            		int sum = 0;
            		int pos_zero = 0;

            		for (int i = 0; i < mas.Length - 1; i++)
            		{
                		if (mas[i] < min) min = mas[i];

                		if (mas[i] == 0) pos_zero++ ;

                		if (pos_zero == 1) sum += mas[i];
            		}
            		int[] res = { Math.Abs(min), sum };
            		return res;
        	}	
        }
    }
}
