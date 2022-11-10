using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _871
    {
        /// <summary>
        /// Runtime: 118 ms, faster than 90.63% of C# online submissions for Minimum Number of Refueling Stops.
        /// Memory Usage: 44.2 MB, less than 12.50% of C# online submissions for Minimum Number of Refueling Stops.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="tank"></param>
        /// <param name="stations"></param>
        /// <returns></returns>
        public int MinRefuelStops(int target, int tank, int[][] stations)
        {
            int result = 0, prev = 0;
            var queue = new PriorityQueue<int, int>();
            for (int i = 0; i <= stations.Length; i++)
            {
                int location = i < stations.Length ? stations[i][0] : target;
                int capacity = i < stations.Length ? stations[i][1] : 0;
                tank = tank - (location - prev);
                while (queue.Count > 0 && tank < 0)
                {
                    result++;
                    tank += queue.Dequeue();
                }
                if (tank < 0)
                    return -1;
                if (i < stations.Length)
                {
                    queue.Enqueue(capacity, -capacity);
                    prev = location;
                }
            }
            return result;
        }
        /// <summary>
        /// Runtime: 133 ms, faster than 78.13% of C# online submissions for Minimum Number of Refueling Stops.
        /// Memory Usage: 39.6 MB, less than 71.88% of C# online submissions for Minimum Number of Refueling Stops.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="tank"></param>
        /// <param name="stations"></param>
        /// <returns></returns>
        public int MinRefuelStops_1(int target, int tank, int[][] stations)
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
