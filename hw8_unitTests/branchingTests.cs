using NUnit.Framework;
using System;

namespace homework_07.Tests
{
    public class branchingTests
    {
        [TestCase(2, 1, 3)]
        [TestCase(5, 5, 25)]
        [TestCase(8, 10, -2)]
        public void Test01(int a, int b, int expected)
        {
            int actual = branching.task01(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(-2147483645, -10)]
        [TestCase(2147483645, 20)]
        public void Test01NegativeTest(int a, int b) => Assert.Throws<OverflowException>(() => branching.task01(a, b));

        [TestCase(2, 1, 1)]
        [TestCase(-1, 3, 4)]
        [TestCase(8, -10, 2)]
        [TestCase(-4, -7, 3)]
        public void Test02(int x, int y, int expected)
        {
            int actual = branching.task02(x, y);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0, 0)]
        [TestCase(1, 0)]
        [TestCase(0, 1)]
        public void Test02NegativeTest1(double x, double y) => Assert.Throws<ArgumentException>(() => branching.task02(21, 0));

        public enum NumbersAscendOrders { Order1st, Order2nd, Order3rd }
        //использовал mock для практики
        public int[] GetAscendOrder(NumbersAscendOrders order)
        {
            switch (order)
            {
                case NumbersAscendOrders.Order1st: return new int[] { 1, 2, 3 };
                case NumbersAscendOrders.Order2nd: return new int[] { -2, 19, 30 };
                case NumbersAscendOrders.Order3rd: return new int[] { 0, 0, 1 };
                default: return null;
            }
        }

        [TestCase(3, 2, 1, NumbersAscendOrders.Order1st)]
        [TestCase(30, -2, 19, NumbersAscendOrders.Order2nd)]
        [TestCase(0, 0, 1, NumbersAscendOrders.Order3rd)]
        public void Test03(int a, int b, int c, NumbersAscendOrders order)
        {
            int[] expected = GetAscendOrder(order);
            int[] actual = branching.task03(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, -1, -15, new double[] { 3, -2.5 })]
        [TestCase(1, -6, 9, new double[] { 3 })]
        [TestCase(3, 1, 2, new double[] { })]
        public void Test04(double a, double b, double c, double[] expected)
        {
            double[] actual = branching.task04(a, b, c);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test04NegativeTest() => Assert.Throws<ArgumentException>(() => branching.task04(0, 1, 2));

        [TestCase(11, "Одиннадцать")]
        [TestCase(19, "Девятнадцать")]
        [TestCase(30, "Тридцать")]
        [TestCase(44, "Сорок Четыре")]
        [TestCase(72, "Семдесят Два")]
        [TestCase(33, "Тридцать Три")]
        [TestCase(67, "Шестьдесят Семь")]
        public void Test05(int a, string expected)
        {
            string actual = branching.task05(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5)]
        [TestCase(0)]
        public void Test05NegativeTest(int a) => Assert.Throws<Exception>(() => branching.task05(a));

        [TestCase(5, 5, 5, true)]
        [TestCase(8, 8, 14, true)]
        [TestCase(12, 10, 8, true)]
        [TestCase(0, 5, 5, false)]
        [TestCase(8, 0, 14, false)]
        [TestCase(12, 10, 0, false)]
        [TestCase(12, 3, 7, false)]
        public void Test06(int a, int b, int c, bool expected)
        {
            bool actual = branching.task06(a, b, c);
            Assert.AreEqual(expected, actual);
        }


    }
}