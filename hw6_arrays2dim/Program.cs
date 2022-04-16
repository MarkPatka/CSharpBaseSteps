﻿using System;

/* 
   task 01 
    Поменять знак на противоположный у всех элементов, расположенных по краям двумерного массива NxM. 
    Изменяющиеся элементы должны образовать "рамочку" толщиной в 1 элемент.
   
   task 02
    Заполнить матрицу 9x9 таблицей умножения:

   task 03
    Заполнить квадратную матрицу NxN (произвольного размера) нулями и единицами так, как расположены клетки на шахматной доске, 
    где 0 - "черное", 1 - "белое". Левое нижнее поле на шахматной доске всегда черное. 
    Обратите внимание - нумерация элементов массива идет сверху вниз, и слева направо. 
    То есть, левое нижнее поле - это поле в последней строке и 0-м столбце.


   task 4 
    Зрительный зал театра имеет N рядов по M мест в каждом ряду. 
    Их можно представить в виде двумерного массива NxM. 
    Если место занято - в массиве стоит значение "1". Если свободно - "0". 
    Образец массива задать вручную, инициализацией в момент создания. 
    На готовом массиве проверить соблюдение "антиковидного правила" (нет двух занятых мест в одном ряду, расположенных рядом, но пропусков может быть сколько угодно). 
    Сделать по оптимальному алгоритму (если нашли два занятых кресла рядом в одном ряду - прервать циклы обхода матрицы).


   task 5
    Фирма имеет 10 магазинов. Доходы каждого магазина за полугодие (6 месяцев с номерами 0-5) хранятся в двумерном вещественном массиве. 
    Заполнить массив случайными вещественными числами. Высчитать:
    а) суммарный доход по каждому магазину;
    б) средний доход по каждому месяцу;
    в) мин. и макс. доход за весь период.


   task 6
    Найти количество элементов массива, которые больше всех своих соседей одновременно. 
    Примечание: соседями элемента считать только 4 потенциальных соседа: на 1 выше, на 1 ниже, на 1 левее и на 1 правее. 
    Обязательно учесть выход за границы массива! При определении критерия, считать сумму соседей для каждого элемента, даже для элемента [0;0] 
    (у него, кстати, будет всего два соседа - [0; 1] и [1; 0]).


   task 7
    Заполнить массив из символов (char) указанным образом (см. рисунок 1).


   task 8
    Реализовать перемножение матриц целых чисел. 
    Проверить входное условие перемножения (число столбцов 1-го массива == числу строк 2-го массива).


   task 9 
    В поле NxM матрицы целых чисел случайно заполнить примерно 10% полей "минами" (значение -1). 
    Потом пройти по остальным полям матрицы и подготовить поле для игры "сапер", заполнив поля без "мин" числом, которое покажет, сколько "мин" примыкает к данной клетке 
    (а вот тут соседей считаем в том числе по диагонали; т.е., все 8 соседей).


   task 10 
    Символьный массив 8x8 считаем шахматной доской. 
    На позиции [v; g] этой доски стоит фигура. 
    Пометить символом "+" любое поле, которое она "бьет" и символом " " (пробел) - которые не бьет. 
    Рассмотреть в 4 этапа следующие фигурыbishop:
    а) ладья
    б) ферзь
    в) слон
    г) конь

*/

namespace arrays2dim
{
    class HW07
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TASK 01");
            Task01.ChangeSign(5, 8);
            Console.WriteLine();

            Console.WriteLine("TASK 02");
            Task02.MultiplicationTable(9, 9);
            Console.WriteLine();

            Console.WriteLine("TASK 03");
            Task03.ChessLikeOrder(11, 11);
            Console.WriteLine();


            Console.WriteLine("TASK 04");
            int[,] cinema = new int[4, 7] {
                                            {0, 0, 1, 0, 1, 0, 1},
                                            {1, 0, 0, 1, 0, 1, 0},
                                            {1, 0, 1, 0, 1, 0, 1},
                                            {0, 1, 0, 1, 0, 1, 0},
                                          };
            Console.WriteLine(Task04.AntiCovidRule(cinema));
            Console.WriteLine();

            Console.WriteLine("TASK 05");
            double[,] arr = ArrayHelper.GenerateMatrix(10, 6, 0, 99999, 3);
            ArrayHelper.PrintMatrix(arr);
            Task05.ShowStatistic(arr);
            Console.WriteLine();

            Console.WriteLine("TASK 06");
            int[,] arr1 = ArrayHelper.GenerateMatrix(4, 5, 0, 10);
            ArrayHelper.PrintMatrix(arr1);
            Task06.BiggestElementsAmongNighbours(arr1);
            Console.WriteLine();

            Console.WriteLine("TASK 07");
            Task07.HourGlassMatrix(10, 10);
            Console.WriteLine();

            Console.WriteLine("TASK 08");
            double[,] arrA = new double[3, 2] {
                                                {2, 4},
                                                {3, 0},
                                                {1, 5},
                                              };
            double[,] arrB = new double[2, 3] {
                                                {3, 2, 1},
                                                {4, 3, 2},
                                              };

            Task08.MatrixMultiplication(arrA, arrB);
            Console.WriteLine();

            Console.WriteLine("TASK 09");
            Task09.SaperField(10, 10);
            Console.WriteLine();

            Console.WriteLine("TASK 10");
            Task10.ChessPieceMove('D', 5, "knight");
            Console.WriteLine();

        }
    }
}