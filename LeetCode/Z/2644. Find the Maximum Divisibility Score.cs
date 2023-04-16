using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2644
    {
        public int MaxDivScore(int[] nums, int[] divisors)
        {
            Array.Sort(divisors/*, (a, b) => (b.CompareTo(a))*/);
            var result = divisors[0];
            var max = 0;
            foreach (var d in divisors)
            {
                var count = 0;
                foreach (var n in nums)
                {
                    if (n % d == 0)
                        count++;
                }
                if (count > max)
                {
                    max = count;
                    result = d;
                }
            }
            return result;
        }
    }
}
