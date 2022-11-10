using System;
using System.Linq;

namespace LeetCode.Z
{
    public class _2078__Two_Furthest_Houses_With_Different_Colors
    {

        /// <summary>
        /// Runtime: 100 ms, faster than 71.43% of C# online submissions for Two Furthest Houses With Different Colors.
        /// Memory Usage: 38.6 MB, less than 6.35% of C# online submissions for Two Furthest Houses With Different Colors.
        /// </summary>
        /// <param name="colors"></param>
        /// <returns></returns>

        public static int MaxDistance(int[] colors)
        {
            var rightMost = Array.FindLastIndex(colors, x => x != colors.First());
            var leftMost = Array.FindIndex(colors, x => x != colors.Last());
            var max = Math.Max(rightMost, colors.Length - leftMost - 1);
            return max;
        }
    }
}