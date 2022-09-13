using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _594
    {
        /// <summary>
        /// Runtime: 256 ms, faster than 24.72% of C# online submissions for Longest Harmonious Subsequence.
        /// Memory Usage: 41.9 MB, less than 74.16% of C# online submissions for Longest Harmonious Subsequence.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindLHS(int[] nums)
        {
            var dic = new Dictionary<int, int>();
            var max = 0;
            foreach (var item in nums)
            {
                dic.TryAdd(item, 0);
                dic[item]++;

                if (dic.ContainsKey(1 + item))
                {
                    max = Math.Max(max, dic[item] + dic[item + 1]);
                }
                if (dic.ContainsKey(item - 1))
                {
                    max = Math.Max(max, dic[item] + dic[item - 1]);
                }
            }
            return max;
        }

        /// <summary>
        /// Runtime: 140 ms, faster than 96.63% of C# online submissions for Longest Harmonious Subsequence.
        /// Memory Usage: 53 MB, less than 11.24% of C# online submissions for Longest Harmonious Subsequence.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindLHS_1(int[] nums)
        {
            var dic = new Dictionary<int, int>();
            foreach (var item in nums)
            {
                dic.TryAdd(item, 0);
                dic[item]++;
            }
            var max = 0;
            foreach (var item in dic)
            {
                if (dic.ContainsKey(1 + item.Key))
                {
                    max = Math.Max(max, dic[item.Key] + dic[item.Key + 1]);
                }
            }
            return max;
        }
    }
}
