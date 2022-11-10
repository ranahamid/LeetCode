using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _137
    {
        /// <summary>
        /// https://lenchen.medium.com/leetcode-137-single-number-ii-31af98b0f462
        /// https://leetcode.com/problems/single-number-ii/solution/
        /// Runtime: 91 ms, faster than 97.10% of C# online submissions for Single Number II.
        /// Memory Usage: 39.8 MB, less than 10.87% of C# online submissions for Single Number II.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber(int[] nums)
        {
            int firstSeen = 0, secondSeen = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                firstSeen = ~secondSeen & (firstSeen ^ nums[i]);
                secondSeen = ~firstSeen & (secondSeen ^ nums[i]);
            }
            return firstSeen;
        }

        /// <summary>
        /// Runtime: 108 ms, faster than 73.91% of C# online submissions for Single Number II.
        /// Memory Usage: 37.8 MB, less than 94.20% of C# online submissions for Single Number II.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber_HashSet(int[] nums)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (result.ContainsKey(nums[i]))
                    result[nums[i]]++;
                else
                    result[nums[i]] = 1;
            }
            foreach (var item in result)
            {
                if (item.Value == 1)
                {
                    return item.Key;
                }
            }
            return 0;
        }
    }
}
