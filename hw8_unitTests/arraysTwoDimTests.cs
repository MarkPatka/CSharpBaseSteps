using NUnit.Framework;
using System.Collections.Generic;
using System;



namespace homework_07.Tests
{
    public class arraysTwoDimTests
    {
        //TASK01
        public enum GetMatrixFrameOutVariants { Matrix4x7, Matrix3x2, Matrix5x6 } //Матрица на выходе
        public int[,] GetMockMatrixTask01(GetMatrixFrameOutVariants variant)
        {
            switch (variant)
            {
                case GetMatrixFrameOutVariants.Matrix3x2:
                    return new int[3, 2] {
                        { -1, -2},
                        { -3, -4},
                        { -5, -6}, };
                case GetMatrixFrameOutVariants.Matrix4x7:
                    return new int[4, 7] {
                        { -1, -1, -1, -1, -1, -1, -1 },
                        { -1, 0, 0, 0, 0, 0, -1},
                        { -1, 0, 0, 0, 0, 0, -1},
                        { -1, -1, -1, -1, -1, -1, -1  }, };
                case GetMatrixFrameOutVariants.Matrix5x6:
                    return new int[5, 6] {
                        { -1, -2, -3, -4, -5, -6 },
                        { -7, 8, 9, 10, 11, -12 },
                        { -13, 14, 15, 16, 17, -18 },
                        { -19, 20, 21, 22, 23, -24 },
                        { -25, -26, -27, -28, -29, -30} };
                default: return null;
            }
        }
        public enum GetMatrixFrameInVariants { Matrix4x7, Matrix3x2, Matrix5x6 } //Матрица на входе
        public int[,] ReturnMockMatrixTask01(GetMatrixFrameInVariants variant)
        {
            switch (variant)
            {
                case GetMatrixFrameInVariants.Matrix3x2:
                    return new int[3, 2] {
                        { 1, 2},
                        { 3, 4},
                        { 5, 6}, };
                case GetMatrixFrameInVariants.Matrix4x7:
                    return new int[4, 7] {
                        { 1, 1, 1, 1, 1, 1, 1 },
                        { 1, 0, 0, 0, 0, 0, 1},
                        { 1, 0, 0, 0, 0, 0, 1},
                        { 1, 1, 1, 1, 1, 1, 1  }, };
                case GetMatrixFrameInVariants.Matrix5x6:
                    return new int[5, 6] {
                        { 1, 2, 3, 4, 5, 6 },
                        { 7, 8, 9, 10, 11, 12 },
                        { 13, 14, 15, 16, 17, 18 },
                        { 19, 20, 21, 22, 23, 24 },
                        { 25, 26, 27, 28, 29, 30} };
                default: return null;
            }
        }

        [TestCase(GetMatrixFrameInVariants.Matrix3x2, GetMatrixFrameOutVariants.Matrix3x2)]
        [TestCase(GetMatrixFrameInVariants.Matrix4x7, GetMatrixFrameOutVariants.Matrix4x7)]
        [TestCase(GetMatrixFrameInVariants.Matrix5x6, GetMatrixFrameOutVariants.Matrix5x6)]
        public void Test01(GetMatrixFrameInVariants variantIN, GetMatrixFrameOutVariants variantOut)
        {
            int[,] actual = ReturnMockMatrixTask01(variantIN);
            int[,] expected = GetMockMatrixTask01(variantOut);
            Assert.AreEqual(expected, arraysTwoDim.Task01(actual));
        }

        //TASK02
        public static int[,] GetMockSpreadsheet9x9(int TableType)
        {
            switch (TableType)
            {
                case 1:
                    int[,] table1 = ArrayHelper.GenerateMatrixInt(9, 9);
                    return table1;
                case 2:
                    int[,] table2 = ArrayHelper.GenerateMatrixInt(9, 9);
                    return table2;
                case 3:
                    int[,] table3 = ArrayHelper.GenerateMatrixInt(9, 9);
                    return table3;
                case 4:
                    int[,] table4 = ArrayHelper.GenerateMatrixInt(9, 9);
                    return table4;
                default: return null;

            }

        }
        public static int[,] GetMultiplicationTableMock(int MultiplicationTable)
        {
            switch (MultiplicationTable)
            {
                case 1:
                    return new int[9, 9] {
                { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                { 2, 4, 6, 8, 10, 12, 14, 16, 18 },
                { 3, 6, 9, 12, 15, 18, 21, 24, 27 },
                { 4, 8, 12, 16, 20, 24, 28, 32, 36},
                { 5, 10, 15, 20, 25, 30, 35, 40, 45},
                { 6, 12, 18, 24, 30, 36, 42, 48, 54},
                { 7, 14, 21, 28, 35, 42, 49, 56, 63},
                { 8, 16, 24, 32, 40, 48, 56, 64, 72},
                { 9, 18, 27, 36, 45, 54, 63, 72, 81}, };
                default: return null;
            }

        }
        public static int[,] GetMockSpreadsheetNegative(int TableType)
        {
            switch (TableType)
            {
                case 1:
                    int[,] table1 = ArrayHelper.GenerateMatrixInt(5, 3);
                    return table1;
                case 2:
                    int[,] table2 = ArrayHelper.GenerateMatrixInt(2, 9);
                    return table2;
                case 3:
                    int[,] table3 = ArrayHelper.GenerateMatrixInt(9, 5);
                    return table3;
                case 4:
                    int[,] table4 = ArrayHelper.GenerateMatrixInt(10, 10);
                    return table4;
                default: return null;
            }
        }

        [TestCase(1, 1)]
        [TestCase(2, 1)]
        [TestCase(3, 1)]
        [TestCase(4, 1)]
        public void Test02(int TableType, int expectedType)
        {
            int[,] check = GetMockSpreadsheet9x9(TableType);
            int[,] expected = GetMultiplicationTableMock(expectedType);
            Assert.AreEqual(expected, arraysTwoDim.Task02(check));
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void Test02NegativeTest(int TableTypeNegative)
        {
            int[,] check = GetMockSpreadsheetNegative(TableTypeNegative);
            Assert.Throws<Exception>(() => arraysTwoDim.Task02(check));
        }

        //TASK03
        public enum GetMatrixMockVariants { BM4x4, BM5x5, BM8x8 }
        public int[,] GetMatrixMock(GetMatrixMockVariants variant)
        {
            switch (variant)
            {
                case GetMatrixMockVariants.BM4x4:
                    return new int[,] { { 0, 0, 0, 0 },
                                        { 0, 0, 0, 0 },
                                        { 0, 0, 0, 0 },
                                        { 0, 0, 0, 0 } };
                case GetMatrixMockVariants.BM5x5:
                    return new int[,] { { 3, 2, 3, 4, 5 },
                                        { 5, 4, 3, 2, 1 },
                                        { 6, 7, 8, 9, 1 },
                                        { 1, 6, 7, 8, 9 },
                                        { 2, 3, 5, 8, 1 } };
                case GetMatrixMockVariants.BM8x8:
                    return new int[,] { { 1, 2, 3, 4, 5, 6, 7, 8 },
                                        { 5, 4, 3, 2, 1, 3, 4, 5 },
                                        { 6, 7, 8, 4, 3, 2, 9, 1 },
                                        { 1, 6, 7, 5, 6, 7, 8, 9 },
                                        { 2, 3, 5, 8, 1, 6, 7, 8 },
                                        { 5, 4, 3, 2, 8, 4, 3, 1 },
                                        { 6, 8, 4, 3, 7, 8, 9, 1 },
                                        { 1, 6, 7, 8, 8, 4, 3, 9 } };
                default: return null;
            }
        }
        public enum GetBinaryMatrixMockVariants { BM4x4, BM5x5, BM8x8 }
        public int[,] GetBinaryMatrixMock(GetBinaryMatrixMockVariants variant)
        {
            switch (variant)
            {
                case GetBinaryMatrixMockVariants.BM4x4:
                    return new int[,] { { 1, 0, 1, 0 },
                                        { 0, 1, 0, 1 },
                                        { 1, 0, 1, 0 },
                                        { 0, 1, 0, 1 } };
                case GetBinaryMatrixMockVariants.BM5x5:
                    return new int[,] { { 0, 1, 0, 1, 0 },
                                        { 1, 0, 1, 0, 1 },
                                        { 0, 1, 0, 1, 0 },
                                        { 1, 0, 1, 0, 1 },
                                        { 0, 1, 0, 1, 0 } };
                case GetBinaryMatrixMockVariants.BM8x8:
                    return new int[,] { { 1, 0, 1, 0, 1, 0, 1, 0 },
                                        { 0, 1, 0, 1, 0, 1, 0, 1 },
                                        { 1, 0, 1, 0, 1, 0, 1, 0 },
                                        { 0, 1, 0, 1, 0, 1, 0, 1 },
                                        { 1, 0, 1, 0, 1, 0, 1, 0 },
                                        { 0, 1, 0, 1, 0, 1, 0, 1 },
                                        { 1, 0, 1, 0, 1, 0, 1, 0 },
                                        { 0, 1, 0, 1, 0, 1, 0, 1 } };
                default: return null;
            }













        }
        public int[,] GetMockNegativeMatrix(int MatrixType)
        {
            switch (MatrixType)
            {
                case 1:
                    return ArrayHelper.GenerateMatrixInt(2, 5);
                case 2:
                    return ArrayHelper.GenerateMatrixInt(8, 6);
                case 3:
                    return ArrayHelper.GenerateMatrixInt(5, 7);
                case 4:
                    return ArrayHelper.GenerateMatrixInt(0, 0);
                default: return null;

            }
        }

        [TestCase(GetMatrixMockVariants.BM4x4, GetBinaryMatrixMockVariants.BM4x4)]
        [TestCase(GetMatrixMockVariants.BM5x5, GetBinaryMatrixMockVariants.BM5x5)]
        [TestCase(GetMatrixMockVariants.BM8x8, GetBinaryMatrixMockVariants.BM8x8)]
        public void Test03(GetMatrixMockVariants variantIN, GetBinaryMatrixMockVariants variantOUT)
        {
            int[,] gotten = GetMatrixMock(variantIN);
            int[,] expected = GetBinaryMatrixMock(variantOUT);
            Assert.AreEqual(expected, arraysTwoDim.Task03(gotten));
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        [TestCase(4)]
        public void Test03NegativeTest(int MatrixTypeNegative)
        {
            int[,] check = GetMockNegativeMatrix(MatrixTypeNegative);
            Assert.Throws<Exception>(() => arraysTwoDim.Task03(check));
        }


        //TASK04
        public int[,] GetCinemaHallsMock(int hall)
        {
            switch (hall)
            {
                case 1:
                    return new int[,]  { { 0, 0, 1, 0, 1},
                                         { 1, 1, 1, 0, 1},
                                         { 0, 0, 0, 1, 1},
                                         { 1, 0, 0, 0, 1},
                                         { 0, 1, 0, 1, 0} };
                case 2:
                    return new int[,] { {  1, 0, 1, 0 },
                                        {  1, 0, 0, 1 },
                                        {  1, 0, 1, 0 } };
                case 3:
                    return new int[,] { { 1, 0, 1, 0, 1, 0, 1, 0 },
                                        { 0, 1, 0, 1, 0, 1, 0, 1 },
                                        { 1, 0, 1, 0, 1, 0, 1, 0 },
                                        { 0, 1, 0, 1, 0, 1, 0, 1 },
                                        { 0, 1, 0, 1, 0, 1, 0, 1 } };
                case 4:
                    return new int[,] { {  0, 0, 0, 0 },
                                        {  0, 1, 1, 0 },
                                        {  0, 0, 0, 0 } };
                default: return null;
            }
        }
        public int[,] GetCinemaHallsMockNegative(int hall)
        {
            switch (hall)
            {
                case 1:
                    return new int[,]  { { 0, 0, 1, 0, 1},
                                         { 6, 0, 1, 0, 1},
                                         { 0, 0, 0, 0, 1},
                                         { 1, 0, 1, 0, 1},
                                         { 0, 1, 1, 1, 9} };
                case 2:
                    return new int[,] { {  -1, 0, -1, 1 },
                                        {  1, 0, -1, 0 },
                                        {  1, 0, -1, 0 } };
                case 3:
                    return new int[,] { {  1, 1, 0, 0 },
                                        {  0, 1, 1, 9 },
                                        {  0, 0, 0, 0 } };
                default: return null;
            }

        }

        [TestCase(1, false)]
        [TestCase(2, true)]
        [TestCase(3, true)]
        [TestCase(4, false)]
        public void Test04(int TypeCinemaHall, bool answer)
        {
            bool expected = answer;
            bool actual = arraysTwoDim.Task04(GetCinemaHallsMock(TypeCinemaHall));
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1)]
        [TestCase(2)]
        [TestCase(3)]
        public void Test04NegativeTest(int TypeCinemaHallNegative)
        {
            int[,] hall = GetCinemaHallsMockNegative(TypeCinemaHallNegative);
            Assert.Throws<Exception>(() => arraysTwoDim.Task04(hall));
        }



        //TEST05
        public double[,] GetDataTableMock(int table)
        {
            switch (table)
            {
                case 1:
                    return new double[,] { { 10, 20, 30, 40, 50, 60 },
                                           { 20, 40, 60, 80, 10, 20 },
                                           { 30, 50, 50, 60, 70, 80 },
                                           { 40, 50, 60, 70, 80, 90 },
                                           { 50, 60, 70, 80, 90, 10 },
                                           { 60, 70, 80, 90, 10, 20 },
                                           { 70, 40, 60, 80, 10, 20 },
                                           { 80, 60, 70, 80, 90, 10 },
                                           { 90, 20, 30, 40, 50, 60 },
                                           { 10, 90, 20, 30, 50, 70 }};
                default: return null;
            }
        }
        public double[,] GetDataTableMockNegative(int ntable)
        {
            switch (ntable)
            {
                case 1:
                    return new double[,] { { 10, 20, 30, 50, 60 },
                                           { 20, 40, 60, 10, 20 },
                                           { 30, 50, 50, 70, 80 },
                                           { 40, 50, 60, 80, 90 },
                                           { 50, 60, 70, 90, 10 },
                                           { 70, 40, 60, 10, 20 },
                                           { 80, 60, 70, 90, 10 },
                                           { 90, 20, 30, 50, 60 },
                                           { 10, 90, 20, 50, 70 }};
                default: return null;
            }

        }
        public (double[], double[], double, double) GetReportMock(int report)
        {
            switch (report)
            {
                case 1:
                    var t = (new double[] { 210.00, 230.00, 340.00, 390.00, 360.00, 330.00, 280.00, 390.00, 290.00, 270.00 },
                               new double[] { 76.67, 83.33, 88.33, 108.33, 85.00, 73.33 },
                               10.00,
                               90.00);
                    return t;
                default: return (null, null, 0, 0);
            }
        }
        [TestCase(1, 1)]
        public void Test05(int tabletype, int report)
        {
            var expected = GetReportMock(report);
            var actual = arraysTwoDim.Task05(GetDataTableMock(tabletype));
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1)]
        public void Test05NegativeTest(int a)
        {
            double[,] table = GetDataTableMockNegative(a);
            Assert.Throws<Exception>(() => arraysTwoDim.Task05(table));


        }




        //TEST06
        public int[,] GetTableMock(int TableNumber)
        {
            switch (TableNumber)
            {
                case 1:
                    return new int[,] { { 1, 1, 1, 1 },
                                        { 1, 2, 1, 1 },
                                        { 1, 1, 1, 2 } };
                case 2:
                    return new int[,] { { 5, 1, 1, 1, 5 },
                                        { 1, 1, 9, 1, 1 },
                                        { 5, 1, 1, 1, 5 },
                                        { 0, 0, 0, 0, 0 } };
                case 3:
                    return new int[,] { { 1, 1, 1, 1, 1 },
                                        { 1, 1, 0, 1, 1 },
                                        { 1, 1, 1, 1, 1 },
                                        { 9, 9, 15, 9, 9 } };
                default: return null;
            }
        }

        [TestCase(1, 2)]
        [TestCase(2, 5)]
        [TestCase(3, 1)]
        public void Test06(int table, int expected)
        {
            int actual = arraysTwoDim.Task06(GetTableMock(table));
            Assert.AreEqual(expected, actual);
        }

        //TEST07
        public enum TableBaseVariants { Table5x6, Table7x7, Table6x5 }
        public enum TableTransformedVariants { Transformed5x6, Transformed7x7, Transformed6x5 }

        public char[,] GetTableBase(TableBaseVariants variant)
        {
            switch (variant)
            {
                case TableBaseVariants.Table5x6:
                    return new char[,] { {  ' ', ' ', ' ', ' ', ' ', ' ' },
                                         {  ' ', ' ', ' ', ' ', ' ', ' ' },
                                         {  ' ', ' ', ' ', ' ', ' ', ' ' },
                                         {  ' ', ' ', ' ', ' ', ' ', ' ' },
                                         {  ' ', ' ', ' ', ' ', ' ', ' ' } };
                case TableBaseVariants.Table7x7:
                    return new char[,] { {  ' ', ' ', ' ', ' ', ' ', ' ', ' '  },
                                         {  ' ', ' ', ' ', ' ', ' ', ' ', ' '  },
                                         {  ' ', ' ', ' ', ' ', ' ', ' ', ' '  },
                                         {  ' ', ' ', ' ', ' ', ' ', ' ', ' '  },
                                         {  ' ', ' ', ' ', ' ', ' ', ' ', ' '  },
                                         {  ' ', ' ', ' ', ' ', ' ', ' ', ' '  },
                                         {  ' ', ' ', ' ', ' ', ' ', ' ', ' '  } };
                case TableBaseVariants.Table6x5:
                    return new char[,] { {  ' ', ' ', ' ', ' ', ' ' },
                                         {  ' ', ' ', ' ', ' ', ' ' },
                                         {  ' ', ' ', ' ', ' ', ' ' },
                                         {  ' ', ' ', ' ', ' ', ' ' },
                                         {  ' ', ' ', ' ', ' ', ' ' },
                                         {  ' ', ' ', ' ', ' ', ' ' } };
                default: return null;
            }
        }

        public char[,] GetTableTransformed(TableTransformedVariants variant)
        {
            switch (variant)
            {
                case TableTransformedVariants.Transformed5x6:
                    return new char[,] { {  '1', '1', '1', '1', '1', '1' },
                                         {  '0', '1', '1', '1', '1', '0' },
                                         {  '0', '0', '1', '1', '0', '0' },
                                         {  '0', '1', '1', '1', '1', '0' },
                                         {  '1', '1', '1', '1', '1', '1' } };
                case TableTransformedVariants.Transformed7x7:
                    return new char[,] { {  '1', '1', '1', '1', '1', '1', '1'  },
                                         {  '0', '1', '1', '1', '1', '1', '0'  },
                                         {  '0', '0', '1', '1', '1', '0', '0'  },
                                         {  '0', '0', '0', '1', '0', '0', '0'  },
                                         {  '0', '0', '1', '1', '1', '0', '0'  },
                                         {  '0', '1', '1', '1', '1', '1', '0'  },
                                         {  '1', '1', '1', '1', '1', '1', '1'  } };
                case TableTransformedVariants.Transformed6x5:
                    return new char[,] { {  '1', '1', '1', '1', '1'  },
                                         {  '0', '1', '1', '1', '0'  },
                                         {  '0', '0', '1', '0', '0'  },
                                         {  '0', '0', '1', '0', '0'  },
                                         {  '0', '1', '1', '1', '0'  },
                                         {  '1', '1', '1', '1', '1'  } };
                default: return null;
            }
        }

        [TestCase(TableBaseVariants.Table5x6, TableTransformedVariants.Transformed5x6)]
        [TestCase(TableBaseVariants.Table6x5, TableTransformedVariants.Transformed6x5)]
        [TestCase(TableBaseVariants.Table7x7, TableTransformedVariants.Transformed7x7)]
        public void Test07(TableBaseVariants variantIN, TableTransformedVariants variantOUT)
        {
            char[,] t = GetTableBase(variantIN);
            char[,] expected = GetTableTransformed(variantOUT);
            Assert.AreEqual(expected, arraysTwoDim.Task07(t));
        }

        //TEST08
        public int[,] GetMatrixAMock(int whichA)
        {
            switch (whichA)
            {
                case 1:
                    return new int[,] { { 1, 3 },
                                        { 6, 2 },
                                        { 7, 0 } };
                case 2:
                    return new int[,] { { 1, 2, 4 },
                                        { 6, 12, 1 },
                                        { 8, 4, 3 },
                                        { -5, 16, 4 } };
                case 3:
                    return new int[,] { { 1, 1, 1, 1, 1 },
                                        { 1, 1, 1, 1, 1 },
                                        { 1, 1, 1, 1, 1 },
                                        { 1, 1, 1, 1, 1 } };
                default: return null;
            }

        }

        public int[,] GetMatrixBMock(int whichB)
        {
            switch (whichB)
            {
                case 1:
                    return new int[,] { { 1, 3, 16 },
                                        { 6, 2, 21 } };
                case 2:
                    return new int[,] { { 1, 2, 4, -5 },
                                        { 6, 12, 1, 16 },
                                        { 8, 4, 3, 4 } };
                case 3:
                    return new int[,] { { 1, 2, 4, 19, 0 },
                                        { 6, 12, 1, 0, 12 },
                                        { 8, 4, 0, 27, 11 },
                                        { -5, 0, 4, 3, 8 },
                                        { 0, 12, 1, 16, -14 } };
                default: return null;
            }
        }

        public int[,] GetAnswerMock(int whichC)
        {
            switch (whichC)
            {
                case 1:
                    return new int[,] { { 19, 9, 79 },
                                            { 18, 22, 138 },
                                            { 7, 21, 112} };
                case 2:
                    return new int[,] { { 45, 42, 18, 43},
                                            { 86, 160, 39, 166 },
                                            { 56, 76, 45, 36 },
                                            { 123, 198, 8, 297} };
                case 3:
                    return new int[,] {     { 10, 30, 10, 65, 17 },
                                            { 10, 30, 10, 65, 17 },
                                            { 10, 30, 10, 65, 17 },
                                            { 10, 30, 10, 65, 17 } };
                default: return null;
            }
        }


        [TestCase(1, 1, 1)]
        [TestCase(2, 2, 2)]
        [TestCase(3, 3, 3)]
        public void Test08(int varintA, int variantB, int variantAnswer)
        {
            int[,] expected = GetAnswerMock(variantAnswer);
            int[,] actual = arraysTwoDim.Task08(GetMatrixAMock(varintA), GetMatrixBMock(variantB));
            Assert.AreEqual(expected, actual);
        }


        [TestCase(1, 2)]
        [TestCase(2, 3)]
        [TestCase(3, 1)]
        public void Test08NegativeTest(int varintA, int variantB) =>  Assert.Throws<Exception>(() => 
                             arraysTwoDim.Task08(GetMatrixAMock(varintA), GetMatrixBMock(variantB)));
   



    }




}