using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Snail
{
    [TestFixture]
    public class ProgramTests
    {
        static object[] arrayCases = 
        {
            new object[] 
            {
                new int[][]  
                {
                new []{1, 2, 3, 44, 5},
                new []{4, 5, 6, 66, 8},
                new []{7, 8, 9, 99, 9},
                new []{10, 11, 12, 1212, 0}           
                },
                new int[] {1,2,3,44,5,8,9,0,1212,12,11,10,7,4,5,6,66,99,9,8}
            }
        };

        [TestCaseSource("arrayCases"), MaxTime(50)]
        public static void CalculateSnailPath_arrayCases(int[][] source, int[] expectedResult)
        {
            int[] result = Program.Snail(source);
            Assert.That(expectedResult, Is.EqualTo(result));
        }
    }
}
