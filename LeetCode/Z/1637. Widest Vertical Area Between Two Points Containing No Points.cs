using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1637
    {
        public int MaxWidthOfVerticalArea(int[][] points)
        {

            Array.Sort(points, (a, b) => a[0].CompareTo(b[0]));
            int ans = 0;
            for (int i = 1; i < points.Length; i++)
            {
                ans = Math.Max(ans, points[i][0] - points[i - 1][0]);
            }
            return ans;
        }
    }
}
