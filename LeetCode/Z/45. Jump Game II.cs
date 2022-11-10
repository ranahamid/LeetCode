using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _45
    {
        /// <summary>
        /// Runtime: 128 ms, faster than 81.74% of C# online submissions for Jump Game II.
        /// Memory Usage: 39.5 MB, less than 66.15% of C# online submissions for Jump Game II.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int Jump(int[] nums)
        {
            var max = 0;
            var prevFarthest = 0;
            var counter = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                max = Math.Max(max, i + nums[i]);
                if (i == prevFarthest)
                {
                    counter++;
                    prevFarthest = max;
                }
            }
            return counter;
        }
    }
}
