using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _252
    {
        /// <summary>
        /// Runtime 193 ms Beats 34.11% Memory 41.5 MB Beats 38.76%
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public bool CanAttendMeetings(int[][] intervals)
        {
            intervals = intervals.OrderBy(x => x[0]).ToArray();
            for (int i = 0; i < intervals.Length - 1; i++)
            {
                //make sure that each meeting ends before the next one starts.
                if (intervals[i][1] > intervals[i + 1][0])
                    return false;
            }
            return true;
        }
        #region brute force 
        /// <summary>
        /// Runtime 177 ms Beats 59.30% Memory 41.5 MB Beats 38.76%
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public bool CanAttendMeetings_bruteforce(int[][] intervals)
        {
            var result = new bool[1000000];
            foreach (var item in intervals)
            {
                for (int i = item[0]; i < item[1]; i++)
                {
                    if (result[i])
                        return false;
                    result[i] = true;
                }
            }
            return true;
        }
        #endregion
    }
}
