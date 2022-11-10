using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _697
    {
        /// <summary>
        /// Runtime: 204 ms, faster than 47.52% of C# online submissions for Degree of an Array.
        /// Memory Usage: 41.2 MB, less than 81.56% of C# online submissions for Degree of an Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindShortestSubArray(int[] nums)
        {
            var dic = GetFrequency(nums);
            var maxNum = dic.Select(x => x.Value).Max();
            var maxValues = dic.Where(x => x.Value == maxNum).OrderByDescending(x => x.Key).Select(x => x.Key).ToList();

            var minVal = int.MaxValue;

            foreach (var max in maxValues)
            {
                var first = int.MinValue;
                var last = int.MinValue;
                for (int i = 0; i < nums.Length; i++)
                {
                    if (nums[i] == max)
                    {
                        if (first == int.MinValue)
                        {
                            first = i;
                            last = i;
                        }
                        last = i;
                    }

                }
                minVal = Math.Min(minVal, last - first + 1);
            }
            return minVal;
        }
        public static Dictionary<int, int> GetFrequency(int[] nums)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i]))
                {
                    map[nums[i]]++;
                }
                else
                {
                    map[nums[i]] = 1;
                }
            }
            return map;
        }
    }
}
