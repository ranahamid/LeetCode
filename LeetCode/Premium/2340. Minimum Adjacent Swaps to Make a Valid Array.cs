using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _2340
    {
        public int MinimumSwaps(int[] nums)
        {
            var length = nums.Length;
            if (length == 1)
                return 0;
            var min = 0;
            var max = length - 1;

            for (int i = 1; i < length; i++)
            {
                if (nums[i] < nums[min])
                    min = i;
            }
            for (int i = length - 2; i >= 0; i--)
            {
                if (nums[i] > nums[max])
                    max = i;
            }
            var total = 0;
            total += length - max - 1;
            total += min;
            if (min >= max)
                total--;
            return total;
        }
    }
}
