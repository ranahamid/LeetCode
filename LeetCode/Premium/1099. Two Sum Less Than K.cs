using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _1099
    {
        /// <summary>
        /// Two pointer
        /// 
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int TwoSumLessThanK(int[] nums, int k)
        {
            int answer = -1;
            int left = 0;
            int right = nums.Length - 1;
            Array.Sort(nums);
            while (left < right)
            {
                var sum = nums[left] + nums[right];
                if (sum < k)
                {
                    answer = Math.Max(answer, sum);
                    left++;
                }
                else
                {
                    right--;
                }
            }
            return answer;
        }
        public int TwoSumLessThanK_brute(int[] nums, int k)
        {
            var max = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    var sum = nums[i] + nums[j];
                    if (sum < k)
                    {
                        max = Math.Max(max, sum);
                    }
                }
            }
            return max;
        }
    }
}
