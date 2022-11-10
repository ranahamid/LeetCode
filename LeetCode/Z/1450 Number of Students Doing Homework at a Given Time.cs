using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1450_Number_of_Students_Doing_Homework_at_a_Given_Time
    {
        /// <summary>
        /// Runtime: 110 ms, faster than 55.26% of C# online submissions for Number of Students Doing Homework at a Given Time.
        /// Memory Usage: 37.9 MB, less than 65.79% of C# online submissions for Number of Students Doing Homework at a Given Time.
        /// </summary>
        /// <param name="startTime"></param>
        /// <param name="endTime"></param>
        /// <param name="queryTime"></param>
        /// <returns></returns>
        public static int BusyStudent(int[] startTime, int[] endTime, int queryTime)
        {
            int count = 0;
            for (int i = 0; i < startTime.Length; i++)
            {
                if (queryTime >= startTime[i] && queryTime <= endTime[i])
                    count++;
            }
            return count;
        }
    }
}
