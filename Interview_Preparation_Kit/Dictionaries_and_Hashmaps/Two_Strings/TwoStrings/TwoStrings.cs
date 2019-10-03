using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoStringsSolution
{
    public class TwoStrings
    {
        public static string substringExists ( string a, string b)
        {
            string searchString;
            char[] chars;
            if (a.Length < b.Length)
                {
                    searchString = a;
                    chars = b.ToCharArray();
                }
                else
                {
                    searchString = b;
                    chars = a.ToCharArray();
                }
                var hashes = new HashSet<char>(chars);
                bool isValid = false;
                foreach (char c in searchString)
                {
                    if (hashes.Contains(c))
                    {
                        isValid = true;
                        break;
                    }
                }
                return isValid ? "YES" : "NO";
        }
    }
}
