using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays2dim
{
    internal class Task05
    {
        public static void ShowStatistic(double[,] arr)
        {
            double[] SummaryIncomeByShops = new double[10];
            double[] AverageIncomeByMonth = new double[6];
            double MaxIncome = 0;
            double MinIncome = double.MaxValue;

            

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                double IncomeByshop = 0;

                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    
                    IncomeByshop += arr[i, j];

                    if (j == arr.GetLength(1) - 1) SummaryIncomeByShops[i] = IncomeByshop;

                    AverageIncomeByMonth[j] += arr[i, j] / 6;

                    MaxIncome = arr[i, j] > MaxIncome ? arr[i, j] : MaxIncome;
                    MinIncome = arr[i, j] < MinIncome ? arr[i,j] : MinIncome;
                }
            }

            Console.WriteLine("Общий доход магазинов: ");
            ArrayHelper.PrintArray(SummaryIncomeByShops);
            Console.WriteLine("Среднемесячный доход ао каждому магазину: ");
            ArrayHelper.PrintArray(AverageIncomeByMonth);
            Console.WriteLine($"Максимальный доход {MaxIncome}, Минимальный доход {MinIncome}");

        }
    }
}
