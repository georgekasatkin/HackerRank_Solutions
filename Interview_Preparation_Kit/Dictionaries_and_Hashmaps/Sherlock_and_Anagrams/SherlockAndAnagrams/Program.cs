using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SherlockAndAnagrams
{
    public class Program
    {
        static void Main(string[] args)
        {
            string source = Console.ReadLine();
            int result = countAnagrams(source);
            Console.WriteLine(result);
            Console.ReadLine();
        }        
        public static int countAnagrams(string s)
        {
            var substringsDict = new Dictionary<string, int>();
            int sum = 0;
            for (int start = 0; start < s.Length; start++)
            {
                for (int tail = 1; tail < s.Length - start + 1; tail++)
                {
                    string subs = s.Substring(start, tail);
                    char[] subsCharArray = subs.ToCharArray();
                    Array.Sort(subsCharArray);
                    subs = new String(subsCharArray);
                    if (!substringsDict.ContainsKey(subs))
                        substringsDict.Add(subs, 1);
                    else
                        substringsDict[subs]++;
                }
            }

            foreach (KeyValuePair<string, int> kvp in substringsDict)
            {
                if (kvp.Value > 1)
                    for (int k = 1; k < kvp.Value; k++)
                        sum += k;
            }
            return sum;
        }
    }
}
