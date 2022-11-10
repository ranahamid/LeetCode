using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _56
    {
        /// <summary>
        /// Runtime 259 ms Beats 70.9% Memory 46.6 MB Beats 66.50%
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public int[][] Merge(int[][] intervals)
        {
            intervals = intervals.OrderBy(x => x[0]).ToArray();
            var result = new List<int[]>();
            var min = intervals[0][0];
            var max = intervals[0][1];

            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i][0] <= max)
                {
                    if (intervals[i][1] > max)
                        max = intervals[i][1];
                }
                else
                {
                    result.Add(new int[] { min, max });
                    min = intervals[i][0];
                    max = intervals[i][1];
                }
            }
            result.Add(new int[] { min, max });
            return result.ToArray();
        }
    }
}
