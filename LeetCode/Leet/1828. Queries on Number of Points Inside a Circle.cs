using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Leet
{
    internal class _1828
    {
        /*
Basic Mathematics will tell you that the distance between two points 
        (x1, y1) and (x2, y2) is given by - sqrt((x1 - x2)^2 + (y1 - y2)^2).

We need the distance between the center of the circle and a point less than or equal to radius of the circle 
        for it to be considered as a point inside the circle.

Thus, we need - (circle_center_x - x1) ^ 2 - (circle_center_y - y1) ^ 2 <= r * r for a point to be inside the circle.
         */
        public int[] CountPoints(int[][] points, int[][] queries)
        {
            var result = new int[queries.Length];
            int i = 0;
            foreach (var q in queries)
            {
                int counter = 0;
                int rr = q[2] * q[2];
                foreach (var p in points)
                {
                    counter += (p[0] - q[0]) * (p[0] - q[0]) + (p[1] - q[1]) * (p[1] - q[1]) <= rr ? 1 : 0;
                }
                result[i++] = counter;
            }
            return result;
        }
    }
}
