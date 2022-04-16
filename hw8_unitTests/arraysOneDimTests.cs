using NUnit.Framework;
using System;

namespace homework_07.Tests
{
    public class arraysOneDimTests
    {
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 2, 3 })]
        [TestCase(new int[] { 1, 1, 2, 2, 2 }, new int[] { 3, 2 })]
        [TestCase(new int[] { 0, 3, 5, 5, 10 }, new int[] { 2, 3 })]
        [TestCase(new int[] { -23, 7, 42, -17, 2 }, new int[] { 2, 3 })]
        public void Test01(int[] arr, int[] expected)
        {
            int[] actual = arraysOneDim.Task01(arr);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test01NegativeTest() => Assert.Throws<Exception>(() => arraysOneDim.Task01(new int[] { }));

        [TestCase(new int[] { 9, 4, 1, 12, 29, 1 }, new int[] { 9, 4, 13, 12, 29, 41 })]
        [TestCase(new int[] { 0, 15, 26, 8, 4, 32, 9, 11, 78 }, new int[] { 0, 15, 15, 8, 4, 12, 9, 11, 20 })]
        [TestCase(new int[] { 0, -100, 25, 4, 10, 99, 29, 1 }, new int[] { 0, -100, -100, 4, 10, 14, 29, 1 })]
        public void Test02(int[] arr, int[] expected)
        {
            int[] actual = arraysOneDim.Task02(arr);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test02NegativeTest1() => Assert.Throws<Exception>(() => arraysOneDim.Task02(new int[] { }));

        [TestCase(new int[] { 1, 1, 1 }, 
                  new int[] { 4, 5, 7, 2 }, 
                  new int[] { 1, 1, 1, 4, 5, 7, 2 })]
        [TestCase(new int[] { 8, 4, 12, 9, 11, 20 }, 
                  new int[] { 0, 15, 15 }, 
                  new int[] { 8, 4, 12, 9, 11, 20, 0, 15, 15 })]
        [TestCase(new int[] { }, 
                  new int[] { 0, -100, 14, 29, 1 }, 
                  new int[] { 0, -100, 14, 29, 1 })]
        [TestCase(new int[] { },
                  new int[] { },
                  new int[] { })]
        public void Test03(int[] arr1, int[] arr2, int[] expected)
        {
            int[] actual = arraysOneDim.Task03(arr1, arr2);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, new int[] { 4, 5, 6, 1, 2, 3})]
        [TestCase(new int[] { 0, -1, -2, -3, -4, -5, -6 }, new int[] { -4, -5, -6, - 3, 0, -1, -2 })]
        [TestCase(new int[] { 1, 2 }, new int[] { 2, 1 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1})]
        public void Test04(int[] arr, int[] expected)
        {
            int[] actual = arraysOneDim.Task04(arr);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test05NegativeTest() => Assert.Throws<Exception>(() => arraysOneDim.Task04(new int[] { }));

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, new int[] { 2, 3, 4, 5, 1 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5 }, 1, new int[] { -4, -5, - 1, -2, -3 })]
        [TestCase(new int[] { 1, 2 }, 1, new int[] { 1, 2 })]
        public void Test05(int[] arr, int n, int[] expected)
        {
            int[] actual = arraysOneDim.Task05(arr, n);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] {1, 3, 2, 5, 4 })]
        [TestCase(new int[] { -1, -2, -3, -4, -5, -6 }, new int[] { -2, -1, -4, -3, -6, -5 })]
        [TestCase(new int[] { 1, 2 },  new int[] { 2, 1 })]
        public void Test06(int[] mas, int[] expected)
        {
            int[] actual = arraysOneDim.Task06(mas);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, new int[] { 1, 0})]
        [TestCase(new int[] { -1, 8, -21, 65, 0, 3 }, new int[] { 21, 3})]
        [TestCase(new int[] { -1, 2, 4, 7, 0, 23, 1, 3, 5, 0, 1, 2 }, new int[] {1, 32})]
        public void Test07(int[] mas, int[] expected)
        {
            int[] actual = arraysOneDim.Task07(mas);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 45, 89, 1, 5, -11 }, new int[] { -11, 1, 3, 5, 45, 89 })]
        [TestCase(new int[] { 0, 23, -2, 0, -2, }, new int[] { -2, -2, 0, 0, 23 })]
        [TestCase(new int[] { 64, 2, 3, 4, 5, -1}, new int[] { -1, 2, 3, 4, 5, 64 })]
        public void Test08(int[] mas, int[] expected)
        {
            int[] actual = arraysOneDim.Task08(mas);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 3, 45, 89, 1, 5, -11 }, new int[] { -11, 1, 3, 5, 45, 89 })]
        [TestCase(new int[] { 0, 23, -2, 0, -2, }, new int[] { -2, -2, 0, 0, 23 })]
        [TestCase(new int[] { 64, 2, 3, 4, 5, -1 }, new int[] { -1, 2, 3, 4, 5, 64 })]
        public void Test09(int[] mas, int[] expected)
        {
            int[] actual = arraysOneDim.Task09(mas);
            Assert.AreEqual(expected, actual);
        }


    }
}