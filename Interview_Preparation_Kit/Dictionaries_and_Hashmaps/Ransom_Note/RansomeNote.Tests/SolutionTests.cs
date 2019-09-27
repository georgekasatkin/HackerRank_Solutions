using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace RansomNote
{
    [TestFixture]
    public class SolutionTests
    {
        static object[] testCases = 
        {
            new object[]
            {
            new string[] {"give", "me", "one", "grand", "today", "night"},
            new string[] {"give", "one", "grand", "today"},
            "Yes"
            },
            new object[]
            {
            new string[] {"h", "ghq", "g", "xxy", "wdnr", "anjst", "xxy", "wdnr", "h", "h", "anjst", "wdnr"},
            new string[] {"h", "ghq"},
            "Yes"
            },
            new object[]
            {
            new string[] {"ive", "got", "a", "lovely", "bunch", "of", "coconuts"},
            new string[] {"ive", "got", "some", "coconuts"},
            "No"
            },
            new object[]
            {
            new string[] {"two", "times", "three", "is", "not", "four"},
            new string[] {"two", "times", "two", "is", "four"},
            "No"
            }
        };
        [Test, TestCaseSource("testCases"), MaxTime(50)]
        public void isValidNote_GoodCases_ReturnsYes(string[] magazine, string[] note, string expectedResult)
        {
            string result = Program.canCreateNoteFromMagazine(magazine, note);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
