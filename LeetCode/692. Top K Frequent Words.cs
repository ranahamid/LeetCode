using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _692
    {
        /// <summary>
        /// Runtime: 229 ms, faster than 61.54% of C# online submissions for Top K Frequent Words.
        /// Memory Usage: 47.3 MB, less than 24.79% of C# online submissions for Top K Frequent Words.
        /// </summary>
        /// <param name="words"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public IList<string> TopKFrequent_LINQ(string[] words, int k)
        {
            return words.GroupBy(x => x).OrderByDescending(x => x.Count()).ThenBy(x => x.Key).Take(k).Select(x => x.Key).ToList();
        }

        /// <summary>
        /// Runtime: 290 ms, faster than 17.95% of C# online submissions for Top K Frequent Words.
        /// Memory Usage: 46.6 MB, less than 83.33% of C# online submissions for Top K Frequent Words.
        /// </summary>
        /// <param name="words"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public IList<string> TopKFrequent(string[] words, int k)
        {
            SortedDictionary<string, int> dic = new SortedDictionary<string, int>();
            foreach (var item in words)
            {
                if (dic.ContainsKey(item))
                {
                    dic[item]++;
                }
                else
                {
                    dic[item] = 1;
                }
            }
            var data = dic.OrderByDescending(x => x.Value).ThenBy(x => x.Key).ToList();
            List<string> result = new List<string>();
            for (int i = 0; i < k; i++)
            {
                result.Add(data[i].Key);
            }
            return result;

        }
    }
}
