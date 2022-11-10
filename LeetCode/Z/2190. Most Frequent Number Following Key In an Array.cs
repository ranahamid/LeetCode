using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2190
    {
        /// <summary>
        /// Runtime: 130 ms, faster than 45.45% of C# online submissions for Most Frequent Number Following Key In an Array.
        /// Memory Usage: 38.9 MB, less than 100.00% of C# online submissions for Most Frequent Number Following Key In an Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static int MostFrequent(int[] nums, int key)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] == key)
                {
                    var target = nums[i];
                    if (map.ContainsKey(target))
                    {
                        map[target]++;
                    }
                    else
                    {
                        map[target] = 1;
                    }
                }
            }
            var max = 0;
            int result = 0;
            foreach (var item in map)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    result = item.Key;
                }
            }
            return result;
        }
    }
}
