using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2335
    {
        /// <summary>
        /// Runtime: 127 ms, faster than 100.00% of C# online submissions for Minimum Amount of Time to Fill Cups.
        /// Memory Usage: 37.5 MB, less than 100.00% of C# online submissions for Minimum Amount of Time to Fill Cups.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public int FillCups(int[] amount)
        {
            var sums = amount.Sum();
            var avg = (int)Math.Ceiling(sums / (double)2.0);
            var maxnum = amount.Max();
            return Math.Max(avg, maxnum);
        }
    }
}
