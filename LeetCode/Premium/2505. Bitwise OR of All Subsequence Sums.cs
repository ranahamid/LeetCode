using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _2505
    {
        public long SubsequenceSumOr(int[] nums)
        {
            long ans = 0;
            long prefix = 0;
            foreach (var n in nums)
            {
                prefix += n;
                ans |= prefix | n;
            }
            return ans;
        }
    }
}
