using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2239
    {
        /// <summary>
        /// Runtime: 109 ms, faster than 95.06% of C# online submissions for Find Closest Number to Zero.
        /// Memory Usage: 44.9 MB, less than 14.81% of C# online submissions for Find Closest Number to Zero.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int FindClosestNumber(int[] nums)
        {
            var distance = Int32.MaxValue;
            var result = 0;
            foreach (var item in nums)
            {
                var dis = Math.Abs(0 - item);
                if ((dis < distance) || (dis == distance && result < item))
                {
                    distance = dis;
                    result = item;
                }
            }
            return result;
        }
    }
}
