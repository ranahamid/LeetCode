using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1004
    {
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
