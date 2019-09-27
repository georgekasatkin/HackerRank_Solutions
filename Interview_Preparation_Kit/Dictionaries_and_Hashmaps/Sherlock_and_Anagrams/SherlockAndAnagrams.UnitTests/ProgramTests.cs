using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace SherlockAndAnagrams
{
    [TestFixture]
    class ProgramTests
    {
        static object[] anagramCases = 
        {
            new object [] {"abba", 4},
            new object[] {"abcd",0},
            new object[] {"ifailuhkqq",3},
            new object[] {"kkkk",10},
            new object[] {"ifailuhkqqhucpoltgtyovarjsnrbfpvmupwjjjfiwwhrlkpekxxnebfrwibylcvkfealgonjkzwlyfhhkefuvgndgdnbelgruel", 399},
            new object[] {"gffryqktmwocejbxfidpjfgrrkpowoxwggxaknmltjcpazgtnakcfcogzatyskqjyorcftwxjrtgayvllutrjxpbzggjxbmxpnde", 471},
            new object[] {"mqmtjwxaaaxklheghvqcyhaaegtlyntxmoluqlzvuzgkwhkkfpwarkckansgabfclzgnumdrojexnrdunivxqjzfbzsodycnsnmw",370},
            new object[] {"ofeqjnqnxwidhbuxxhfwargwkikjqwyghpsygjxyrarcoacwnhxyqlrviikfuiuotifznqmzpjrxycnqktkryutpqvbgbgthfges",403},
            new object[] {"zjekimenscyiamnwlpxytkndjsygifmqlqibxxqlauxamfviftquntvkwppxrzuncyenacfivtigvfsadtlytzymuwvpntngkyhw",428},
            new object[] {"dfcaabeaeeabfffcdbbfaffadcacdeeabcadabfdefcfcbbacadaeafcfceeedacbafdebbffcecdbfebdbfdbdecbfbadddbcec", 2452},
            new object[] {"bcgdehhbcefeeadchgaheddegbiihehcbbdffiiiifgibhfbchffcaiabbbcceabehhiffggghbafabbaaebgediafabafdicdhg", 1305},
            new object[] {"aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa",166650}
        };

        [Test, TestCaseSource("anagramCases"), MaxTime(100)]
        public void countAnagrams_anagramsCases_returnsTrue(string source, int expectedResult)
        {            
            int result = Program.countAnagrams(source);            
            Assert.AreEqual(expectedResult, result);
        }
    }
}
