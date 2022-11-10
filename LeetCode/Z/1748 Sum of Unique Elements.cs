using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1748_Sum_of_Unique_Elements
    {
        /// <summary>
        /// Runtime: 100 ms, faster than 84.50% of C# online submissions for Sum of Unique Elements.
        /// Memory Usage: 37.1 MB, less than 44.19% of C# online submissions for Sum of Unique Elements.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SumOfUnique(int[] nums)
        {
            Dictionary<int, int> result = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (result.ContainsKey(nums[i]))
                {
                    result[nums[i]]++;
                }
                else
                {
                    result.Add(nums[i], 1);
                }
            }
            var sum = 0;
            foreach (var item in result)
            {
                if (item.Value == 1)
                    sum += item.Key;
            }
            return sum;
        }
    }
}
