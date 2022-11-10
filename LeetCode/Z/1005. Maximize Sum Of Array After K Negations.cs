using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1005
    {
        /// <summary>
        /// Runtime: 96 ms, faster than 97.83% of C# online submissions for Maximize Sum Of Array After K Negations.
        /// Memory Usage: 37.8 MB, less than 67.39% of C# online submissions for Maximize Sum Of Array After K Negations.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int LargestSumAfterKNegations(int[] nums, int k)
        {
            Array.Sort(nums);
            var kCount = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < 0 && kCount < k)
                {
                    kCount++;
                    nums[i] = nums[i] * -1;
                }
                else
                {
                    break;
                }
            }
            Array.Sort(nums);
            if (kCount == k || nums[0] == 0 || (k - kCount) % 2 == 0)
                return nums.Sum();
            else
                return nums.Sum() - nums[0] * 2;
        }
    }
}
