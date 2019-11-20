using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snail
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int[]> rowList = new List<int[]>();
            while (true)
            {
                string s = Console.ReadLine();
                if (s == String.Empty)
                    break;
                else
                {
                    int[] row = Array.ConvertAll(s.Split(' '), Int32.Parse);
                    rowList.Add(row);
                }
            }            
            int l = rowList.Count;
            int[][] array = new int[l][];
            for (int i = 0; i < l; i++)
            {
                array[i] = rowList[i];
            }            
            int[] result = Snail(array);
            foreach (int i in result)
                Console.Write(i + " ");
            Console.ReadLine();

        }
        public static int[] Snail(int[][] array)
        {
            int verticalSize = array.GetUpperBound(0) + 1;
            int horisontalSize = array[0].GetUpperBound(0) + 1;
            int[] result = new int[verticalSize * horisontalSize];
            int resultId = 0;
            int i = 0, j = 0;
            int lowerX = -1, lowerY = -1, upperX = horisontalSize, upperY = verticalSize;
            while (resultId < result.Length)
            {
                //left to right
                for (; i < upperX; i++)
                {
                    result[resultId++] = array[j][i];
                }
                i--;
                upperX--;
                j++;

                //top to bottom
                for (; j < upperY; j++)
                {
                    result[resultId++] = array[j][i];
                }
                j--;
                upperY--;
                i--;

                //right to left
                for (; i > lowerX; i--)
                {
                    result[resultId++] = array[j][i];
                }
                i++;
                lowerX++;
                j--;

                //bottom to top
                lowerY++;
                for (; j > lowerY; j--)
                {
                    result[resultId++] = array[j][i];
                }
                j++;
                i++;
            }
            return result;
        }
    }
}
