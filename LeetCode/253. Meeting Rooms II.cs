using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _253
    {
        /// <summary>
        /// Runtime 155 ms Beats 75.16% Memory 39.6 MB Beats 47.34%
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public int MinMeetingRooms(int[][] intervals)
        {
            var starts = intervals.Select(x => x[0]).OrderBy(x=>x).ToList();
            var ends = intervals.Select(x => x[1]).OrderBy(x => x).ToList();
            
            int result = 0;
            int j = 0;
            for (int i = 0; i < intervals.Length; i++)
            {
                if (starts[i] < ends[j])
                    result++;
                else
                    j++;
            }
            return result;
        }
    }
}
