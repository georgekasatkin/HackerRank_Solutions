using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace FrequencyQueries
{
    [TestFixture]
    public class ProgramTests
    {
        static object[] queryCases = 
        {
            new object[]
            {
                new List<List<int>>() 
                { 
                new List<int> { 1, 1 }, 
                new List<int> { 2, 2 },
                new List<int> { 3, 2 },
                new List<int> { 1, 1 },
                new List<int> { 1, 1 },
                new List<int> { 2, 1 },
                new List<int> { 3, 2 }
                },
                new List<int>() { 0, 1 }
            },
            new object[]
            {
                new List<List<int>>() 
                { 
                new List<int> { 1, 5 }, 
                new List<int> { 1, 6 },
                new List<int> { 3, 2 },
                new List<int> { 1, 10 },
                new List<int> { 1, 10 },
                new List<int> { 1, 6 },
                new List<int> { 2, 5 },
                new List<int> { 3, 2 }
                },
                new List<int>() { 0, 1 }
            },
            new object[]
            {
                new List<List<int>>() 
                { 
                new List<int> { 3, 4 }, 
                new List<int> { 2, 1003 },
                new List<int> { 1, 16 },
                new List<int> { 3, 1 }                
                },
                new List<int>() { 0, 1 }
            },
            new object[]
            {
                new List<List<int>>() 
                { 
                new List<int> { 1, 3 }, 
                new List<int> { 2, 3 },
                new List<int> { 3, 2 },
                new List<int> { 1, 4 },  
                new List<int> { 1, 5 },  
                new List<int> { 1, 5 },  
                new List<int> { 1, 4 },  
                new List<int> { 3, 2 },  
                new List<int> { 2, 4 },
                new List<int> { 3, 2 }  
                },
                new List<int>() { 0, 1, 1 }
            }
        };

        [TestCaseSource("queryCases"), MaxTime(50)]
        public static void ShowQueriesResults_queryCases(List<List<int>> source, List<int> expectedResult)
        {
            List<int> result = Program.FreqQuery(source);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
