using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1232
    {
        /// <summary>
        /// Runtime: 136 ms, faster than 57.64% of C# online submissions for Check If It Is a Straight Line.
        /// Memory Usage: 40 MB, less than 62.50% of C# online submissions for Check If It Is a Straight Line.
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public bool CheckStraightLine(int[][] coordinates)
        {
            for (int i = 0; i < coordinates.Length - 2; i++)
            {
                if (IsAreaZero(coordinates[i][0], coordinates[i][1], coordinates[i + 1][0], coordinates[i + 1][1], coordinates[i + 2][0], coordinates[i + 2][1]) == false)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool IsAreaZero(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            var area = x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2);
            return area == 0;
        }
    }
}
