using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _347
    {
        /// <summary>
        /// Runtime: 158 ms, faster than 94.72% of C# online submissions for Top K Frequent Elements.
        /// Memory Usage: 46.3 MB, less than 12.75% of C# online submissions for Top K Frequent Elements.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[] TopKFrequent(int[] nums, int k)
        {
            var set = GetFrequency(nums);
            var list = set.OrderByDescending(x => x.Value).Take(k).Select(x => x.Key).ToList();
            return list.ToArray();
        }
        public static Dictionary<int, int> GetFrequency(int[] s)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (map.ContainsKey(s[i]))
                {
                    map[s[i]]++;
                }
                else
                {
                    map[s[i]] = 1;
                }
            }
            return map;
        }
    }
}
