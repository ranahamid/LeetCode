using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2214
    {
        public long MinimumHealth(int[] damage, int armor)
        {
            long sum = damage.Select(x => (long)x).Sum() + 1;
            var max = damage.Max();

            sum -= Math.Min(max, armor);
            return sum;
        }
    }
}
