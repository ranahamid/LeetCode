using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_310
{
    internal class _2406
    {
        /// <summary>
        /// Runtime: 1060 ms, faster than 100.00% of C# online submissions for Divide Intervals Into Minimum Number of Groups.
        /// Memory Usage: 55.2 MB, less than 100.00% of C# online submissions for Divide Intervals Into Minimum Number of Groups.
        /// </summary>
        /// <param name="intervals"></param>
        /// <returns></returns>
        public int MinGroups(int[][] intervals)
        {
            intervals = intervals.OrderBy(x => x[0]).ThenBy(x => x[1]).ToArray();
            var pq = new PriorityQueue<int, int>();
            var counter = 0;
            for (int i = 0; i < intervals.Length; i++)
            {
                var start = intervals[i][0];
                var end = intervals[i][1];
                if (pq.Count == 0 || pq.Peek() > start)
                    counter++;
                else
                    pq.Dequeue();
                pq.Enqueue(end + 1, end + 1);
            }
            return counter;
        }
    }
}
