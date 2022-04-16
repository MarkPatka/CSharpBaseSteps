using System;

namespace homework_07
{
    class methods
    {

        static void Main(string[] args)
        {
            IOHelper.Divider(100);
            Console.WriteLine("\nHOMEWORK 01\n");
            IOHelper.Divider(100);

            Console.WriteLine("task01");
            variables.task01(2, 5.3); 
            IOHelper.Divider(50);

            Console.WriteLine("task02");
            Console.WriteLine(variables.task02(2.5, 6.4));
            IOHelper.Divider(50);

            Console.WriteLine("task03");
            Console.WriteLine(variables.task03("ololol", "ulululu"));
            IOHelper.Divider(50);

            Console.WriteLine("task04");
            Console.WriteLine(variables.task04(2.4, 5.1, 9.7));
            IOHelper.Divider(50);

            Console.WriteLine("task05");
            Console.WriteLine(variables.task05(2, 3, 8, 12));
            IOHelper.Divider(50);

            
            Console.WriteLine("task06");
            double x1 = 0, x2 = 0;
            if (variables.task06(1, 9, 3, ref x1, ref x2) == 0) Console.WriteLine("Решений нет!");
            else if (variables.task06(1, 9, 3, ref x1, ref x2) == 1) Console.WriteLine($"D = 0:\nx1 = {x1}");
            else
                Console.WriteLine($"D > 0:\nx1 = {x1}; x2 = {x2}");
            IOHelper.Divider(50);

            IOHelper.Divider(100);
            Console.WriteLine("\nHOMEWORK 02\n");
            IOHelper.Divider(100);

            Console.WriteLine("task01");
            Console.WriteLine(mathExpressions.task01());
            IOHelper.Divider(50);

            Console.WriteLine("task02");
            Console.WriteLine(mathExpressions.task02(2, 5, 15));
            IOHelper.Divider(50);

            Console.WriteLine("task03");
            bool answer;
            if (mathExpressions.task03(354) == 1) answer = true;
            else
                answer = false;
            Console.WriteLine($"{answer}");
            IOHelper.Divider(50);


            Console.WriteLine("task04");
            Console.WriteLine(mathExpressions.task04(456));
            IOHelper.Divider(50);

            Console.WriteLine("task05");
            Console.WriteLine(mathExpressions.task05(156.7));
            IOHelper.Divider(50);

            IOHelper.Divider(100);
            Console.WriteLine("\nHOMEWORK 03\n");
            IOHelper.Divider(100);

            Console.WriteLine("task01");
            Console.WriteLine(branching.task01(4, 9));
            IOHelper.Divider(50);

            Console.WriteLine("task02");
            Console.WriteLine(branching.task02(4, 9));
            IOHelper.Divider(50);

            Console.WriteLine("task03");
            int A1 = 0, B1 = 0, C1 = 0;
            branching.task03(3, -10, 85, ref A1, ref B1, ref C1);
            Console.Write($"В порядке возрастания: | {C1} | {B1} | {A1} |" +
                $"\nВ порядке убывания:    | {A1} | {B1} | {C1} |\n");
            IOHelper.Divider(50);

            Console.WriteLine("task04");
            Console.WriteLine(branching.task05(99));
            IOHelper.Divider(50);

            Console.WriteLine("task06");
            if (branching.task06(4, 4, 4) == 1) Console.WriteLine("Треугольник существует!");
            else
                Console.WriteLine("Такого треугольника не существует!");
            IOHelper.Divider(50);

            IOHelper.Divider(100);
            Console.WriteLine("\nHOMEWORK 04\n");
            IOHelper.Divider(100);

            Console.WriteLine("task01");
            Console.WriteLine(cycles.task01(50));
            IOHelper.Divider(50);

            Console.WriteLine("task02");
            Console.WriteLine(cycles.task02(17));
            IOHelper.Divider(50);

            Console.WriteLine("task03");
            Console.WriteLine(cycles.task03(27));
            IOHelper.Divider(50);

            Console.WriteLine("task04");
            Console.WriteLine(cycles.task04(7, 21));
            IOHelper.Divider(50);

            Console.WriteLine("task05");
            Console.WriteLine(cycles.task05(312, 92));
            IOHelper.Divider(50);

            Console.WriteLine("task06");
            Console.WriteLine(cycles.task06(50653));
            IOHelper.Divider(50);

            Console.WriteLine("task07");
            Console.WriteLine(cycles.task07(-237));
            IOHelper.Divider(50);

            Console.WriteLine("task08");
            Console.WriteLine(cycles.task08(87674));
            IOHelper.Divider(50);

            Console.WriteLine("task09");
            Console.WriteLine(cycles.task09(164));
            IOHelper.Divider(50);

            Console.WriteLine("task10");
            Console.WriteLine(cycles.task10(397, -91));
            IOHelper.Divider(50);

            IOHelper.Divider(100);
            Console.WriteLine("\nHOMEWORK 05\n");
            IOHelper.Divider(100);


            Console.WriteLine("task01");
            int Oddcnt = 0; 
            int Evencnt = 0;
            arraysOneDim.Task01(10, ref Oddcnt, ref Evencnt);
            Console.WriteLine($"Нечетные: {Oddcnt}, Четные: {Evencnt}");
            IOHelper.Divider(50);

            Console.WriteLine("task02");
            arraysOneDim.Task02(10);
            IOHelper.Divider(50);

            Console.WriteLine("task03");
            arraysOneDim.Task03(7, 5);
            IOHelper.Divider(50);

            Console.WriteLine("task04");
            arraysOneDim.Task04(8);
            IOHelper.Divider(50);

            Console.WriteLine("task05");
            arraysOneDim.Task05(9, 5);
            IOHelper.Divider(50);

            Console.WriteLine("task06");
            int cnt = 0;
            arraysOneDim.Task06(11, ref cnt);
            Console.WriteLine($"Программа выполнена за {cnt} итераций");
            IOHelper.Divider(50);


// Возможно, что я неверно понял условие (task07), решив, что программа должна считать, в случае если в массиве есть 2 нуля, только
//    числа между ними. Реализовать программу менее громоздким способом, с учетом данного условия у меня не вышло...
//    Программа решающая задачу без данного условия приведена в качестве приватного метода в arrayaOneDim.cs после (public static void Task07)

            Console.WriteLine("task07");
            int[] mas = new int[10] { -1, 13, -5, 8, 0, -9, 16, 3, 0, 5 };
            int minElem = 0;
            int sumAfterZero = 0;
            arraysOneDim.Task07(mas, ref minElem, ref sumAfterZero);
            Console.WriteLine($"Мин. (по модулю) элемент: {minElem}\nСумма после нахождения первого нуля: {sumAfterZero}");
            IOHelper.Divider(50);


            Console.WriteLine("task08");
            int[] mas1 = new int[10] { -1, 13, -5, 8, 0, -9, 16, 3, 0, 5 };
            arraysOneDim.Task08(mas1);
            IOHelper.Divider(50);

            Console.WriteLine("task09");
            int[] mas2 = new int[10] { -1, 3, -54, 35, 0, -9, -20, 3, 0, 66 };
            arraysOneDim.Task09(mas2);
            IOHelper.Divider(50);

            IOHelper.Divider(100);
            Console.WriteLine("\nHOMEWORK 06\n");
            IOHelper.Divider(100);

            Console.WriteLine("task01");
            arraysTwoDim.Task01(5, 8);
            IOHelper.Divider(50);

            Console.WriteLine("task02");
            arraysTwoDim.Task02(10, 10);
            IOHelper.Divider(50);

            Console.WriteLine("task03");
            arraysTwoDim.Task03(8, 8);
            IOHelper.Divider(50);

            Console.WriteLine("task04");
            int[,] cinema = new int[5, 6] {
                {1, 0, 1, 0, 1, 0 },
                {1, 0, 0, 0, 1, 0 },
                {0, 1, 1, 0, 1, 0 },
                {1, 0, 1, 0, 0, 1 },
                {0, 1, 0, 1, 1, 0 }};

            Console.WriteLine(arraysTwoDim.Task04(cinema));
            IOHelper.Divider(50);


            Console.WriteLine("task05");
            double sumMAX = 0;
            double sumMIN = double.MaxValue;
            arraysTwoDim.Task05(10, 6, ref sumMAX, ref sumMIN);
            IOHelper.Divider(50);

            Console.WriteLine("task06");
            int[,] matrix = ArrayHelper.GenerateMatrixInt(3, 5);
            arraysTwoDim.Task06(matrix);
            IOHelper.Divider(50);

            Console.WriteLine("task07");
            arraysTwoDim.Task07(7,7);
            IOHelper.Divider(50);

            Console.WriteLine("task08");
            int[,] matrA = new int[2, 3] {
                {3, 4, 1 },
                {2, 8, 5 } };

            int[,] matrB = new int[3, 3] {
                {1, 9, 6 },
                {7, 2, 4 },
                {1, 9, 1 } };
            arraysTwoDim.Task08(matrA, matrB);
            IOHelper.Divider(50);





        }
    }
}
