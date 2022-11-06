using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2104
    {
        public long SubArrayRanges(int[] nums)
        {
            var length = nums.Length;
            long result = 0;
            for (int i = 0; i < length; i++)
            {
                int minVal = nums[i];
                int maxVal = nums[i];
                for (int j = i; j < length; j++)
                {
                    minVal = Math.Min(minVal, nums[j]);
                    maxVal = Math.Max(maxVal, nums[j]);
                    result += maxVal - minVal;
                }
            }
            return result;
        }
    }
}
