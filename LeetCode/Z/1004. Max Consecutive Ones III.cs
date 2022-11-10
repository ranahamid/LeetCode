using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1004
    {
        #region sliding window
        public int LongestOnes(int[] nums, int k)
        {
            int left = 0, right = 0;
            for (right = 0; right < nums.Length; right++)
            {
                if (nums[right] == 0)
                {
                    k--;
                }
                if (k < 0)
                {
                    k = k + 1 - nums[left];
                    left++;
                }
            }
            return right - left;
        }
        #endregion
        #region TLE
        public int LongestOnes_TLE(int[] nums, int k)
        {
            var set = new List<int>();
            var max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var zeroCount = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    if (nums[j] == 0)
                    {
                        zeroCount++;
                    }
                    if (zeroCount <= k)
                    {
                        max = Math.Max(max, j - i + 1);
                    }
                }
            }
            return max;
        }
        #endregion
    }
}
