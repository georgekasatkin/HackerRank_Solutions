using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TwoStringsSolution
{
    [TestFixture]
    public class ProgramTests
    {
        static object[] stringCases = 
        {
            new string[] {"hello", "world", "YES"},
            new string[] {"hi","world", "NO"},
            new string[] {"wouldyoulikefries","abcabcabcabcabcabc", "NO"},
            new string[] {"hackerrankcommunity","cdecdecdecde", "YES"},
            new string[] {"jackandjill","wentupthehill", "YES"},
            new string[] {"writetoyourparents","fghmqzldbc", "NO"},
            new string[] {"aardvark","apple", "YES"},
            new string[] {"beetroot","sandals", "NO"}
        };
        [Test, TestCaseSource("stringCases"), MaxTime(100)]
        public void getResponse_anagramCases_ReturnsTrue(string a, string b, string expectedResult)
        {
            string result = TwoStrings.substringExists(a, b);
            Assert.AreEqual(expectedResult, result);
        }

    }
}
