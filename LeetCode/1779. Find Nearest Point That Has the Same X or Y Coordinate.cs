using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1779
    { /// <summary>
      /// Runtime: 376 ms, faster than 55.59% of C# online submissions for Find Nearest Point That Has the Same X or Y Coordinate.
      /// Memory Usage: 48.1 MB, less than 58.39% of C# online submissions for Find Nearest Point That Has the Same X or Y Coordinate.
      /// </summary>
      /// <param name="x"></param>
      /// <param name="y"></param>
      /// <param name="points"></param>
      /// <returns></returns>
        public int NearestValidPoint(int x, int y, int[][] points)
        {
            var index = -1;
            var mn = Int32.MaxValue;
            for (int i = 0; i < points.Length; i++)
            {
                if (points[i][0] == x || points[i][1] == y)
                {
                    var manhattan = Math.Abs(points[i][0] - x) + Math.Abs(points[i][1] - y);
                    if (manhattan < mn)
                    {
                        mn = manhattan;
                        index = i;
                    }
                }
            }
            return index;
        }
    }
}
