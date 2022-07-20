using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Week_1
{
    internal class Sparse_Arrays
    {
        public static List<int> matchingStrings(List<string> strings, List<string> queries)
        {
            var result = new List<int>();
            for (int i = 0; i < queries.Count; i++)
            {
                var data = strings.Count(x => x == queries[i]);
                result.Add(data);
            }
            return result;
        }
    }
}
