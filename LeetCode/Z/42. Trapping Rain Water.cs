using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _42
    {
        /// <summary>
        /// Runtime: 99 ms, faster than 95.45% of C# online submissions for Trapping Rain Water.
        /// Memory Usage: 43.1 MB, less than 5.38% of C# online submissions for Trapping Rain Water.
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public int Trap(int[] height)
        {
            var length = height.Length;
            var leftMax = new int[length];
            var rightMax = new int[length];
            for (int i = 1; i < length; i++)
            {
                leftMax[i] = Math.Max(leftMax[i - 1], height[i - 1]);
            }

            for (int i = length - 2; i > 0; i--)
            {
                rightMax[i] = Math.Max(rightMax[i + 1], height[i + 1]);
            }
            int result = 0;
            for (int i = 0; i < length; i++)
            {
                var waterLevel = Math.Min(leftMax[i], rightMax[i]);
                if (waterLevel > height[i])
                {
                    result += waterLevel - height[i];
                }
            }
            return result;
        }
    }
}
