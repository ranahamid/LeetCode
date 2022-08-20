using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _871
    {
        /// <summary>
        /// Runtime: 133 ms, faster than 78.13% of C# online submissions for Minimum Number of Refueling Stops.
        /// Memory Usage: 39.6 MB, less than 71.88% of C# online submissions for Minimum Number of Refueling Stops.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="tank"></param>
        /// <param name="stations"></param>
        /// <returns></returns>
        public int MinRefuelStops(int target, int tank, int[][] stations)
        {
            var result = 0;
            var prev = 0;
            var queue = new PriorityQueue<int, int>();
            int location = 0, capacity = 0;
            for (int i = 0; i < stations.Length; i++)
            {
                location = stations[i][0];
                capacity = stations[i][1];
                tank = tank - (location - prev);
                while (queue.Count > 0 && tank < 0)
                {
                    result++;
                    var val = queue.Dequeue();
                    tank += val;
                }
                if (tank < 0)
                    return -1;
                queue.Enqueue(capacity, -capacity);
                prev = location;
            }
            //last position 
            tank = tank - (target - prev);
            while (queue.Count > 0 && tank < 0)
            {
                result++;
                var val = queue.Dequeue();
                tank += val;
            }
            if (tank < 0)
                return -1;
            return result;
        }
    }
}
