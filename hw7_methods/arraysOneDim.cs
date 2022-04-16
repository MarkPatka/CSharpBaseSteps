using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_07
{
    class arraysOneDim
    {

        public static void Task01(int size, ref int Oddcnt, ref int Evencnt)
        {
            int[] mas = ArrayHelper.GenerateArrayInt(size, -100, 101);

            for (int i = 0; i < size; i++)
            {
                if (mas[i] % 2 == 0) Evencnt++;
                else
                    Oddcnt++;
            }
        }

        public static int[] Task02(int size)
        {
            int[] mas = ArrayHelper.GenerateArrayInt(size, -100, 101);
            int sumprev = 0;

            IOHelper.ArrIntConsOut1(mas);
            for (int i = 2; i < size; i += 3)
            {
                mas[i] = 0;
                sumprev = mas[i - 2] + mas[i - 1];
                mas[i] = sumprev;
            }
            IOHelper.ArrIntConsOut1(mas);

            return mas;
        }

        public static int[] Task03(int size1, int size2)
        {
            int[] mas1 = ArrayHelper.GenerateArrayInt(size1, -100, 101);
            int[] mas2 = ArrayHelper.GenerateArrayInt(size2, -100, 101);

            int[] mas3 = new int[size1 + size2];
            mas1.CopyTo(mas3, 0);
            mas2.CopyTo(mas3, size1);

            IOHelper.ArrIntConsOut3(mas1, mas2, mas3);

            return mas3;
        }

        public static int[] Task04(int size)
        {
            int[] mas = ArrayHelper.GenerateArrayInt(size, -100, 101);
            IOHelper.ArrIntConsOut1(mas);

            for (int i = 0; i < mas.Length / 2; i++)
            {
                if (mas.Length % 2 == 0) ArrayHelper.swap(ref mas[(size / 2) + i], ref mas[i]);
                else
                    ArrayHelper.swap(ref mas[(size / 2) + i + 1], ref mas[i]);

            }

            IOHelper.ArrIntConsOut1(mas);
            return mas;
        }

        public static int[] Task05(int size, int shift)
        {
            int[] mas = ArrayHelper.GenerateArrayInt(size, -100, 101);
            IOHelper.ArrIntConsOut1(mas);
            int[] shiftedMas = new int[size];


            for (int i = size - 1; i >= 0; i--)
            {
                if (shift + i >= size) shiftedMas[i + shift - size] = mas[i];
                else
                    shiftedMas[shift + i] = mas[i];
            }

            IOHelper.ArrIntConsOut1(shiftedMas);
            return shiftedMas;
        }

        public static int[] Task06(int size, ref int cnt)
        {
            int[] mas = ArrayHelper.GenerateArrayInt(size, -100, 101);
            IOHelper.ArrIntConsOut1(mas);

            for (int i = mas.Length - 1; i >= 0; i -= 2)
            {
                if (i == 0) break;

                ArrayHelper.swap(ref mas[i], ref mas[i - 1]);
                cnt++;
            }

            IOHelper.ArrIntConsOut1(mas);
            return mas;
        }

        private static int CountZeroes(int[] mas)
        {
            int cntZeroes = 0;

            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] == 0) cntZeroes++;
            }

            return cntZeroes;
        }

        private static Tuple<int, int> FindTwoZeroValuePositions(int[] mas)
        {
            int FirstZeroIndex = -1;
            int SecondZeroIndex = -1;
            int cntZeroes = CountZeroes(mas);

            if (cntZeroes >= 2)
            {
                for (int i = 0; i < mas.Length; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        if (mas[i] == mas[j]) FirstZeroIndex = i;
                    }
                }

                for (int i = FirstZeroIndex; i < mas.Length; i++)
                {
                    for (int j = i + 1; j < mas.Length; j++)
                    {
                        if (mas[i] == mas[j]) SecondZeroIndex = j;
                    }
                }

            }

            return Tuple.Create(FirstZeroIndex, SecondZeroIndex);

        }


        public static void Task07(int[] mas, ref int minElem, ref int sumAfterZero)
        {
            minElem = Math.Abs(mas[0]);
            sumAfterZero = 0;
            int cntZeroes = CountZeroes(mas);

            if (cntZeroes >= 2)
            {
                var btwZeroes = FindTwoZeroValuePositions(mas);

                for (int i = (int)btwZeroes.Item1; i < (int)btwZeroes.Item2; i++)
                {
                    sumAfterZero += mas[i];
                }
            }
            else if (cntZeroes == 1)
            {
                int zeroposition = -1;
                for (int i = 0; i < mas.Length; i++)
                {
                    if (mas[i] == 0) zeroposition = i;
                }
                for (int i = zeroposition; i < mas.Length; i++)
                {
                    sumAfterZero += mas[i];
                }
            }

            for (int i = 0; i < mas.Length; i++)
            {
                if (Math.Abs(mas[i]) < minElem) minElem = mas[i];
            }

        }

        private void Task07Ver2 (int[] mas, ref int min, ref int sum)
        {
            Math.Abs(mas[0]);
            sum = 0;
            int pos_zero = -1;

            for (int i = 0; i < mas.Length; i++)
            {
                if (Math.Abs(mas[i]) < min) min = mas[i];
                if (mas[i] == 0) pos_zero = i;
                if (i >= pos_zero && pos_zero != -1) sum += mas[i];
            }

        }

        public static int[] Task08 (int[] mas)
        {
            for (int i = 1; i < mas.Length; i++)
            {
                int elem = mas[i];
                int j = i;
                while (j > 0 && elem < mas[j - 1])
                {
                    mas[j] = mas[j - 1];
                    j--;
                }
                mas[j] = elem;
            }
            IOHelper.ArrIntConsOut1(mas);
            return mas;
        }

        public static int[] Task09(int[] mas)
        {
            for (int i = 0; i < mas.Length - 1; i++)
            {
                int min_pos = i;
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[j] < mas[min_pos]) min_pos = j;
                }
                ArrayHelper.swap(ref mas[i], ref mas[min_pos]);
            }
            IOHelper.ArrIntConsOut1(mas);
            return mas;
        }




    }
}
