using System;
using NUnit.Framework;

namespace _2D_Array_DS
{
    [TestFixture]
    class ProgramTests
    { 
        static object[] arrayCases = 
        {
            new object[]
            {
                new int[6][] 
                {
                    new int[] { 1, 1, 1, 0, 0, 0 }, 
                    new int[] { 0, 1, 0, 0, 0, 0 },
                    new int[] { 1, 1, 1, 0, 0, 0 },
                    new int[] { 0, 0, 2, 4, 4, 0 },
                    new int[] { 0, 0, 0, 2, 0, 0 },
                    new int[] { 0, 0, 1, 2, 4, 0 }
                },
            19
            },
            new object[]
            {
                new int[6][] 
                {
                    new int[] { -9, -9, -9,  1, 1, 1 }, 
                    new int[] {  0, -9,  0,  4, 3, 2 },
                    new int[] { -9, -9, -9,  1, 2, 3 },
                    new int[] {  0,  0,  8,  6, 6, 0 },
                    new int[] {  0,  0,  0, -2, 0, 0 },
                    new int[] {  0,  0,  1,  2, 4, 0 }
                },
            28
            },
            new object[]
            {
                new int[6][] 
                {
                    new int[] { 1, 1,  1,  0,  0, 0 }, 
                    new int[] { 0, 1,  0,  0,  0, 0 },
                    new int[] { 1, 1,  1,  0,  0, 0 },
                    new int[] { 0, 9,  2, -4, -4, 0 },
                    new int[] { 0, 0,  0, -2,  0, 0 },
                    new int[] { 0, 0, -1, -2, -4, 0 }
                },
            13
            }
        };
        [Test, TestCaseSource("arrayCases"), MaxTime(100)]
        public void countMaxHourglassSum_arrayCases_returnsTrue(int[][] source, int expectedResult)
        {
            int result = Program.countMaxHourglassSum(source);
            Assert.AreEqual(expectedResult, result);
        }

    }
}
