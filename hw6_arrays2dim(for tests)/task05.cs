using System;

namespace task_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int shops = 10;
            int month = 6;
            double[] sumGEN = new double[10];
            double[] sumMON = new double[10];
            double sumMAX = 0;
            double sumMIN = double.MaxValue;


            Random rnd = new Random();
            double[,] matrix = new double[shops, month];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = Math.Round((rnd.NextDouble() * 10000), 2, MidpointRounding.AwayFromZero);
                    sumGEN[i] += matrix[i, j];
                    sumMON[i] += matrix[i, j] / 6;
                    sumMAX = (matrix[i, j] > sumMAX ? matrix[i, j] : sumMAX);
                    sumMIN = (matrix[i, j] < sumMIN ? matrix[i, j] : sumMIN);


                }
                Console.WriteLine($"Суммарный доход {i + 1}-го магазина: {Math.Round(sumGEN[i], 2, MidpointRounding.AwayFromZero)}");
                Console.WriteLine($"Среднемесячный доход {i + 1}-го магазина: {Math.Round(sumMON[i], 2, MidpointRounding.AwayFromZero)}");

            }
            Console.WriteLine($"\nНаибольший месячный доход составил: {sumMAX}\nНаименьший месячный доход составил: {sumMIN}");

        }
    }
}
