using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1523
    {
        /// <summary>
        /// Runtime: 29 ms, faster than 84.71% of C# online submissions for Count Odd Numbers in an Interval Range.
        /// Memory Usage: 26.6 MB, less than 9.41% of C# online submissions for Count Odd Numbers in an Interval Range.
        /// </summary>
        /// <param name="low"></param>
        /// <param name="high"></param>
        /// <returns></returns>
        public int CountOdds(int low, int high)
        {
            var range = high - low;
            var div = range / 2;
            if (low % 2 == 1 || high % 2 == 1)
            {
                div++;
            }
            return div;
        }
    }
}
