using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1060
    {
        /// <summary>
        /// Runtime 275 ms Beats 54.76% Memory 44.5 MB Beats 83.33%
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="index"></param>
        /// <returns></returns>
        public int Missing(int[] nums, int index)
        {
            return nums[index] - nums[0] - index;
        }
        public int MissingElement(int[] nums, int k)
        {
            var n = nums.Length;
            if (k > Missing(nums, n - 1))
                return nums[n - 1] + k - Missing(nums, n - 1);

            int left = 0, right = n - 1;
            while (left != right)
            {
                var mid = left + (right - left) / 2;
                if (Missing(nums, mid) < k)
                    left = mid + 1;
                else
                    right = mid;
            }
            return nums[left - 1] + k - Missing(nums, left - 1);
        }
    }
}
