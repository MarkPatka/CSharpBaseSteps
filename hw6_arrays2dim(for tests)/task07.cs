using System;

namespace task_07
{
    class Program
    {
        static void Main(string[] args)
        {
		public static int[,] Task07(int[,] matrix)
        	{
            		for (int i = 0; i < matrix.GetLength(0); i++)
            		{
                		for (int j = 0; j < matrix.GetLength(1); j++)
                		{
                    			matrix[i, j] = 1;
                		}
            		}

            		for (int j = 0; j < matrix.GetLength(1); j++)
            		{
                		if (j % 2 == 0)
                		{
                    			for (int i = j + 1; i < matrix.GetLength(0) - j - 1; i++)
                    			{
                        			matrix[i, j] = matrix[i, matrix.GetLength(1) - 1 - j] =  0;
                    			}
                		}
               		 	else
                		{
                    			for (int i = matrix.GetLength(0) - 2 - j; i >= j + 1; i--)
                    			{
                        			matrix[i, j] = matrix[i, matrix.GetLength(1) - 1 - j] = 0;
                    			}
                		}

        		}
            		return matrix;
        	}
        
            
        }

    }

}
