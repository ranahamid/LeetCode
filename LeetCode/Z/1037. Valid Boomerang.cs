using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1037
    {
        /// <summary>
        /// Runtime: 78 ms, faster than 100.00% of C# online submissions for Valid Boomerang.
        /// Memory Usage: 40.4 MB, less than 7.14% of C# online submissions for Valid Boomerang.
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        public bool IsBoomerang(int[][] points)
        {
            var x1 = points[0][0];
            var x2 = points[1][0];
            var x3 = points[2][0];

            var y1 = points[0][1];
            var y2 = points[1][1];
            var y3 = points[2][1];


            var area = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);
            if (area == 0)
                return false;
            return true;
        }
    }
}
