using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FrequencyQueries
{
    public class Program
    {
        static void Main(string[] args)
        {
            int q = Convert.ToInt32(Console.ReadLine().Trim());            
            List<List<int>> queries = new List<List<int>>();
            for (int i = 0; i < q; i++)
            {
                queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
            }
            List<int> ans = FreqQuery(queries);
            Console.WriteLine(String.Join("\n", ans));
            Console.ReadLine();
        }
        public static List<int> FreqQuery(List<List<int>> queries)
        {
            int l = queries.Count;
            Dictionary<int, int> dict = new Dictionary<int, int>(l);
            Dictionary<int, int> frequencies = new Dictionary<int, int>();
            List<int> result = new List<int>();
            for (int i = 0; i < l; i++)
            {
                switch (queries[i][0])
                {
                    case 1:
                        {
                            if (dict.ContainsKey(queries[i][1]))
                                dict[queries[i][1]]++;
                            else
                                dict.Add(queries[i][1], 1);
                            EditFrequencies(-1, dict[queries[i][1]], ref frequencies);
                            break;
                        }
                    case 2:
                        {
                            if (dict.ContainsKey(queries[i][1]) && dict[queries[i][1]] > 0)
                            {
                                dict[queries[i][1]]--;
                                EditFrequencies(1, dict[queries[i][1]], ref frequencies);
                            }
                            break;
                        }
                    default:
                        {
                            if (frequencies.ContainsKey(queries[i][1]) && frequencies[queries[i][1]] > 0)
                                result.Add(1);
                            else
                                result.Add(0);
                            break;
                        }
                }
            }
            return result;
        }
        public static void EditFrequencies(int modifier, int dictCurrentElement, ref Dictionary<int, int> frequencies)
        {
            if (frequencies.ContainsKey(dictCurrentElement))
                frequencies[dictCurrentElement]++;
            else
                frequencies.Add(dictCurrentElement, 1);

            if (frequencies.ContainsKey(dictCurrentElement + modifier))
                frequencies[dictCurrentElement + modifier]--;
            else
                frequencies.Add(dictCurrentElement + modifier, 1);
        }
    }
}
