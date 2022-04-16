using NUnit.Framework;
using System.Collections.Generic;
using System;

namespace homework_07.Tests
{
    public class cyclesTests
    {

        public enum DividedOnAMockVariants { On50, On100, On300 }
        public List<int> DividedOnAMock(DividedOnAMockVariants variant)
        {
            switch (variant)
            {
                case DividedOnAMockVariants.On100:
                    return new List<int>(new int[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 });
                case DividedOnAMockVariants.On300:
                    return new List<int>(new int[] { 300, 600, 900 });
                case DividedOnAMockVariants.On50:
                    return new List<int>(new int[] { 50, 100, 150, 200, 250, 300, 350, 400, 450, 500,
                                                     550, 600, 650, 700, 750, 800, 850, 900, 950, 1000 });
                default: return null;

            }
        }


        [TestCase(50, DividedOnAMockVariants.On50)]
        [TestCase(100, DividedOnAMockVariants.On100)]
        [TestCase(300, DividedOnAMockVariants.On300)]
        public void Test01(int a, DividedOnAMockVariants variant)
        {
            List<int> expected = DividedOnAMock(variant);
            List<int> actual = cycles.task01(a);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test01NegativeTest()
        {
            Assert.Throws<DivideByZeroException>(() => cycles.task01(0));
            Assert.Throws<ArgumentOutOfRangeException>(() => cycles.task01(1001));
        }

        [TestCase(16, 3)]
        [TestCase(81, 8)]
        [TestCase(0, 0)]
        [TestCase(-25, 0)]
        public void Test02(int a, int expected)
        {
            int actual = cycles.task02(a);
            Assert.AreEqual(expected, actual); 
        }

        [Test]
        public void Test02NegativeTest()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => cycles.task02(2127483647));
        }

        [TestCase(25, 5)]
        [TestCase(-12, 6)]
        [TestCase(101, 1)]
        public void Test03(int a, int expected)
        {
            int actual = cycles.task03(a);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test03NegativeTest()
        {
            Assert.Throws<DivideByZeroException>(() => cycles.task03(0));
        }

        [TestCase(1, 22, 42)]
        [TestCase(22, 1, 42)]
        [TestCase(0, 0, 0)]
        [TestCase(-9, 14, 14)]
        [TestCase(-7, 13, 0)]
        [TestCase(3, 3, 0)]
        [TestCase(7, 7, 7)]
        public void Test04(int a, int b, int expected)
        {
            int actual = cycles.task04(a, b);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test04NegativeTest()
        {
            Assert.Throws<OverflowException>(() => cycles.task04(7, 2147483647));
        }

        [TestCase(38, 16, 2)]
        [TestCase(7, 14, 7)]
        [TestCase(7, 7, 7)]
        [TestCase(42, -12, 6)]
        [TestCase(-12, 6, 6)]
        [TestCase(101, 3, 1)]
        public void Test05(int a, int b, int expected)
        {
            int actual = cycles.task05(a, b);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test05NegativeTest()
        {
            Assert.Throws<Exception>(() => cycles.task05(0, 0));
        }

        [TestCase(125, 5)]
        [TestCase(1, 1)]
        [TestCase(0, 0)]
        [TestCase(2744, 14)]
        public void Test06(int a, int expected)
        {
            int actual = cycles.task06(a);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test06NegativeTest()
        {
            Assert.Throws<ArgumentException>(() => cycles.task06(-12));
            Assert.Throws<ArgumentException>(() => cycles.task06(65));
            Assert.Throws<ArgumentException>(() => cycles.task06(344));
        }

        [TestCase(579530, 5)]
        [TestCase(55555, 5)]
        [TestCase(-13579, 5)]
        [TestCase(-6754328, 3)]
        [TestCase(11, 2)]
        [TestCase(10, 1)]
        [TestCase(6842, 0)]
        public void Test07(int a, int expected)
        {
            int actual = cycles.task07(a);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test07NegativeTest()
        {
            Assert.Throws<ArgumentException>(() => cycles.task06(6));
        }

        [TestCase(111, 111)]
        [TestCase(100, 001)]
        [TestCase(2453, 3542)]
        [TestCase(-2453, -3542)]
        [TestCase(-100, -001)]
        [TestCase(1, 1)]
        public void Test08(int a, int expected)
        {
            int actual = cycles.task08(a);
            Assert.AreEqual(expected, actual);
        }

        public enum EvensMoreOddsVariants { Untill20, Untill30, Untill50 }
        public List<int> EvensMoreOdds(EvensMoreOddsVariants variant)
        {
            switch (variant)
            {
                case EvensMoreOddsVariants.Untill20:
                    return new List<int>(new int[] { 12, 14, 16, 18, 20 });
                case EvensMoreOddsVariants.Untill30:
                    return new List<int>(new int[] { 12, 14, 16, 18, 20, 21, 22, 24, 26, 28 });
                case EvensMoreOddsVariants.Untill50:
                    return new List<int>(new int[] { 12, 14, 16, 18, 20, 21, 22, 24, 26, 28, 34, 
                                                     36, 38, 40, 41, 42, 43, 44, 46, 48 });
                default: return null;
            }
        }

        [TestCase(20, EvensMoreOddsVariants.Untill20)]
        [TestCase(30, EvensMoreOddsVariants.Untill30)]
        [TestCase(50, EvensMoreOddsVariants.Untill50)]
        public void Test09(int a, EvensMoreOddsVariants variant)
        {
            List<int> expected = EvensMoreOdds(variant);
            List<int> actual = cycles.task09(a);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test09NegativeTest()
        {
            Assert.Throws<ArgumentException>(() => cycles.task06(-241));
            Assert.Throws<ArgumentException>(() => cycles.task06(6));
        }

        [TestCase(123, 345, "ÄÀ")]
        [TestCase(4123, 29, "ÄÀ")]
        [TestCase(-567, 527, "ÄÀ")]
        [TestCase(123, 456, "ÍÅÒ")]
        [TestCase(1, 1, "ÄÀ")]
        [TestCase(-274, -135, "ÍÅÒ")]
        public void Test10(int a, int b, string expected)
        {
            string actual = cycles.task10(a, b);
            Assert.AreEqual(expected, actual);
        }




    }
}