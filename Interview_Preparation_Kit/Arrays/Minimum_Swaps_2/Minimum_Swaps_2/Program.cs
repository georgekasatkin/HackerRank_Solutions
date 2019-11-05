using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minimum_Swaps_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int count = minSwaps(arr);
            Console.WriteLine(count);
            Console.ReadLine();
        }
        static void swap(int a, int b, ref int[] arr)
        {
            int tmp = arr[a];
            arr[a] = arr[b];
            arr[b] = tmp;
        }
        public static int minSwaps(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != i + 1)
                {
                    swap(i, arr[i] - 1, ref arr);
                    count++;
                    i--;
                }
            }
            return count;
        }
    }
}
