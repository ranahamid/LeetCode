using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
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
            var dic = new Dictionary<string, int>();
            foreach (var item in words)
            {
                dic.TryAdd(item, 0);
                dic[item]++;
            }

            var result = dic.OrderByDescending(x => x.Value).ThenBy(x => x.Key).Take(k).ToDictionary(x => x.Key, x => x.Value);

            var answer = new List<string>();
            foreach (var item in result)
            {
                answer.Add(item.Key);
            }
            return answer;
        }
    }
}
