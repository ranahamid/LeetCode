using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2529
    {
        public int MaximumCount(int[] nums)
        {
            var minus = 0;
            var plus = 0;
            foreach (var n in nums)
            {
                if (n < 0)
                    minus++;
                else if (n > 0) plus++;
            }
            return Math.Max(minus, plus);
        }
    }
}
