using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _259
    {
        /// <summary>
        /// Runtime 102 ms Beats 100% Memory 39.5 MB Beats 7.84%
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int ThreeSumSmaller(int[] nums, int target)
        {
            var length = nums.Length;
            var counter = 0;
            Array.Sort(nums);
            for (int i = 0; i < nums.Length - 2; i++)
            {
                counter += TwoSumSmaller(nums, target - nums[i], i + 1);
            }
            return counter;
        }
        public int TwoSumSmaller(int[] nums, int target, int startIndex)
        {
            int left = startIndex;
            int right = nums.Length - 1;
            int sum = 0;
            while (left < right)
            {
                if (nums[left] + nums[right] < target)
                {
                    sum += right - left;
                    left++;
                }
                else
                    right--;
            }
            return sum;
        }
    }
}
