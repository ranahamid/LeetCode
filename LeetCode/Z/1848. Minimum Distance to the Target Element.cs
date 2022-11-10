using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1848
    {
        /// <summary>
        /// Runtime: 92 ms, faster than 95.45% of C# online submissions for Minimum Distance to the Target Element.
        /// Memory Usage: 39.5 MB, less than 9.09% of C# online submissions for Minimum Distance to the Target Element.
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <param name="start"></param>
        /// <returns></returns>
        public int GetMinDistance(int[] nums, int target, int start)
        {
            int min = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == target)
                {
                    min = Math.Min(min, Math.Abs(i - start));
                    if (min == 0)
                        return 0;
                }
            }
            return min;
        }
    }
}
