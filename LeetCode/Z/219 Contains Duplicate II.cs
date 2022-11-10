using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _219_Contains_Duplicate_II
    {
        /// <summary>
        /// Runtime: 229 ms, faster than 89.66% of C# online submissions for Contains Duplicate II.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static bool ContainsNearbyDuplicate(int[] nums, int k)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (result.ContainsKey(nums[i]))
                {
                    if (i - result[nums[i]] <= k)
                        return true;
                    else
                        result[nums[i]] = i;
                }
                else
                {
                    result.Add(nums[i], i);
                }

            }
            return false;
        }
    }
}
