using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2D_Array_DS
{
    public class Program
    {
        static void Main(string[] args)
        {  
            int[][] arr = new int[6][];
            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }
            int result = countMaxHourglassSum(arr);
            Console.WriteLine(result);
            Console.ReadLine();            
        }
        public static int countMaxHourglassSum(int[][] arr)
        {
            int maxSum = int.MinValue;
            int currentSum = 0;
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    currentSum = 0;
                    for (int i = 0; i < 3; i++)
                    {
                        currentSum += arr[x][y + i];
                        currentSum += arr[x + 2][y + i];
                    }
                    currentSum += arr[x + 1][y + 1];
                    if (currentSum > maxSum)
                        maxSum = currentSum;
                }
            }            
            return maxSum;
        }
    }
}
