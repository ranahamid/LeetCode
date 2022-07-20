using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _746
    {
        /// <summary>
        /// Runtime: 171 ms, faster than 12.12% of C# online submissions for Min Cost Climbing Stairs.
        /// Memory Usage: 38 MB, less than 38.37% of C# online submissions for Min Cost Climbing Stairs.
        /// </summary>
        /// <param name="cost"></param>
        /// <returns></returns>
        public int MinCostClimbingStairs_2(int[] cost)
        {
            var minCost = new int[cost.Length + 1];
            minCost[0] = 0;
            minCost[1] = 0;
            for (var i = 2; i < cost.Length + 1; i++)
            {
                minCost[i] = Math.Min(minCost[i - 1] + cost[i - 1], minCost[i - 2] + cost[i - 2]);
            }
            return minCost[cost.Length];
        }
        /// <summary>
        /// Runtime: 123 ms, faster than 59.79% of C# online submissions for Min Cost Climbing Stairs.
        /// Memory Usage: 38.2 MB, less than 28.49% of C# online submissions for Min Cost Climbing Stairs.
        /// </summary>
        /// <param name="cost"></param>
        /// <returns></returns>
        public int MinCostClimbingStairs_1(int[] cost)
        {
            var downOne = 0;
            var downTwo = 0;
            for (var i = 2; i < cost.Length + 1; i++)
            {
                var temp = downOne;
                downOne = Math.Min(downOne + cost[i - 1], downTwo + cost[i - 2]);
                downTwo = temp;
            }
            return downOne;
        }
    }
}
