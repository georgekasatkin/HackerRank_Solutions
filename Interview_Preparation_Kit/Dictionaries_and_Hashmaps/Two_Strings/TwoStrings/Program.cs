using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TwoStringsSolution
{
    class Program
    {        
        static void Main(string[] args)
        {
            int t = Int32.Parse(Console.ReadLine());
            string a, b;            
            for (int i = 0; i < t; i++)
            {
                a = Console.ReadLine();
                b = Console.ReadLine();
                string result = TwoStrings.substringExists(a, b);
                Console.WriteLine(result);
            }
        }
    }
}
