using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Minimum_Swaps_2
{
    [TestFixture]
    public class ProgramTests
    {
        static object[] arrayCases = 
        {
            new object[] 
            {
            new int[] {4,3,1,2}, 
            3
            },
            new object[] 
            {
            new int[] {2,3,4,1,5}, 
            3
            },
            new object[] 
            {
            new int[] {1,3,5,2,4,6,7}, 
            3
            }
        };

        [Test, TestCaseSource("arrayCases"), MaxTime(100)]
        public void countMinimumSwaps_arrayCases_returnsTrue(int[] source, int expectedResult)
        {
            int result = Program.minSwaps(source);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
