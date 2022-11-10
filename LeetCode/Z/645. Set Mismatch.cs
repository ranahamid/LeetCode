using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _645
    {
        /// <summary>
        /// Runtime: 306 ms, faster than 21.28% of C# online submissions for Set Mismatch.
        /// Memory Usage: 46.9 MB, less than 51.06% of C# online submissions for Set Mismatch.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int[] FindErrorNums(int[] nums)
        {
            Array.Sort(nums);
            var n = nums.Length;
            var missingNumber = 1;
            var duplicateNumber = 0;
            for (int i = 1; i < n; i++)
            {
                if (nums[i] == nums[i - 1])
                {
                    duplicateNumber = nums[i];
                }
                else if (nums[i] > nums[i - 1] + 1)
                {
                    missingNumber = nums[i - 1] + 1;
                }
            }
            if (nums[nums.Length - 1] != nums.Length)
                missingNumber = nums.Length;

            return new int[] { duplicateNumber, missingNumber };
        }
    }
}
