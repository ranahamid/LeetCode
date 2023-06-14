using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2733
    {
        public int FindNonMinOrMax(int[] nums)
        {
            var length = nums.Count();
            if (length < 3)
                return -1;
            Array.Sort(nums);
            return nums[1];
        }
    }
}
