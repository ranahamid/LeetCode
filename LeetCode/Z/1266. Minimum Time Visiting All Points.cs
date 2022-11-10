using System;

namespace LeetCode.Z
{
    public class _1266__Minimum_Time_Visiting_All_Points
    {

        /// <summary>
        /// Runtime: 120 ms, faster than 62.96% of C# online submissions for Minimum Time Visiting All Points.
        /// Memory Usage: 37.8 MB, less than 69.14% of C# online submissions for Minimum Time Visiting All Points.
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        public static int MinTimeToVisitAllPoints(int[][] points)
        {
            int counter = 0;
            for (int i = 0; i < points.Length - 1; i++)
            {
                var one = Math.Abs(points[i][0] - points[i + 1][0]);
                var two = Math.Abs(points[i][1] - points[i + 1][1]);
                counter += Math.Max(one, two);

            }

            return counter;
        }

    }
}