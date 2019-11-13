using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RansomNote
{
    public class Program
    {
        public static string CanCreateNoteFromMagazine(string[] magazine, string[] note)
        {
            Dictionary<string, int> magazineDictionary = new Dictionary<string, int>();
            foreach (string s in magazine)
            {
                if (magazineDictionary.ContainsKey(s))
                    magazineDictionary[s]++;
                else
                    magazineDictionary.Add(s, 1);
            }

            bool validNote = true;
            foreach (string s in note)
            {
                if (!magazineDictionary.ContainsKey(s) || --magazineDictionary[s] < 0)
                {
                    validNote = false;
                    return "No";
                }
            }
            return validNote ? "Yes" : "No";
        }
        static void Main(string[] args)
        {
            string[] magazine = Array.ConvertAll(Console.ReadLine().Split(' '), tmp => tmp);
            string[] note = Array.ConvertAll(Console.ReadLine().Split(' '), tmp => tmp);
            string result = CanCreateNoteFromMagazine(magazine, note);
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
