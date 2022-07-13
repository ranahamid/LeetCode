
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _1708
    { 
        public int[] LargestSubarray(int[] nums, int k)
        {
            var result = new int[k];
            if (nums.Length < k)
                return result;

            var maxInd = 0;
            for (int i = 1; i <= nums.Length - k; i++)
            {
                if (nums[i] > nums[maxInd])
                {
                    maxInd = i;
                }
            }
            return nums.Skip(maxInd).Take(k).ToArray();
        }
    }
}
