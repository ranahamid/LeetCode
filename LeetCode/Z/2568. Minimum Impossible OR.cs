using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2568
    {
        /// <summary>
        /// Runtime: 189 ms, faster than 82.00% of C# online submissions for Minimum Impossible OR.
        /// Memory Usage: 54 MB, less than 50.00% of C# online submissions for Minimum Impossible OR.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MinImpossibleOR(int[] nums)
        {

            var set = new HashSet<int>(nums);
            int a = 1;
            while (set.Contains(a))
                a <<= 1;
            return a;
        }
    }
}
