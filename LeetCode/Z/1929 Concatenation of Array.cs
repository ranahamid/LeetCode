using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1929_Concatenation_of_Array
    {
        /// <summary>
        /// Runtime: 142 ms, faster than 97.79% of C# online submissions for Concatenation of Array.
        /// Memory Usage: 48.2 MB, less than 7.45% of C# online submissions for Concatenation of Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] GetConcatenation(int[] nums)
        {
            var res = nums.ToList();
            res.AddRange(nums);
            return res.ToArray();
        }

        /// <summary>
        /// Runtime: 227 ms, faster than 31.86% of C# online submissions for Concatenation of Array.
        /// Memory Usage: 45.7 MB, less than 40.69% of C# online submissions for Concatenation of Array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int[] GetConcatenation_2(int[] nums)
        {
            var len = nums.Length;
            Array.Resize(ref nums, 2 * len);
            for (int i = 0; i < len; i++)
            {
                nums[len + i] = nums[i];
            }
            return nums;
        }
    }
}
