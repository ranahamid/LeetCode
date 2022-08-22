using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _213
    {
        #region range
        public int Rob_1(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            else if (nums.Length == 1)
                return nums[0];

            var max1 = RobCalc(nums, 0, nums.Length - 1);
            var max2 = RobCalc(nums, 1, nums.Length);
            var max = Math.Max(max1, max2);
            return max;
        }
        public int RobCalc(int[] nums, int start, int end)
        {
            if (nums.Length == 0)
                return 0;
            int prev1 = 0;
            int prev2 = 0;
            for (int i = start; i < end; i++)
            {
                var num = nums[i];
                int temp = prev1;
                prev1 = Math.Max(num + prev2, prev1);
                prev2 = temp;
            }
            return prev1;
        }
        #endregion
        #region two call
        public int Rob_2(int[] nums)
        {
            if (nums.Length == 0)
                return 0;
            else if (nums.Length == 1)
                return nums[0];
            var second = new int[nums.Length - 1];
            var first = new int[nums.Length - 1];
            int firstCounter = 0, secondCounter = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0)
                {
                    first[firstCounter++] = nums[i];
                }
                else if (i == nums.Length - 1)
                {
                    second[secondCounter++] = nums[i];
                }
                else
                {
                    first[firstCounter++] = nums[i];
                    second[secondCounter++] = nums[i];
                }
            }
            var max1 = RobSum(first);
            var max2 = RobSum(second);
            var max = Math.Max(max1, max2);
            return max;
        }
        public int RobSum(int[] nums)
        {
            if (nums.Length == 0)
                return 0;

            int prev1 = 0;
            int prev2 = 0;
            foreach (var num in nums)
            {
                int temp = prev1;
                prev1 = Math.Max(num + prev2, prev1);
                prev2 = temp;
            }
            return prev1;
        }
        #endregion
    }
}
