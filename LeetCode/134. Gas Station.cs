using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _134
    {
        /// <summary>
        /// Runtime: 196 ms, faster than 94.59% of C# online submissions for Gas Station.
        /// Memory Usage: 51.2 MB, less than 6.19% of C# online submissions for Gas Station.
        /// </summary>
        /// <param name="gas"></param>
        /// <param name="cost"></param>
        /// <returns></returns>
        public int CanCompleteCircuit(int[] gas, int[] cost)
        {
            if (gas.Sum() < cost.Sum())
                return -1;
            var diff = new int[gas.Length];
            for (int i = 0; i < gas.Length; i++)
            {
                diff[i] = gas[i] - cost[i];
            }
            var total = 0;
            var result = 0;
            for (int i = 0; i < diff.Length; i++)
            {
                total += diff[i];
                if (total < 0)
                {
                    total = 0;
                    result = i + 1;
                }
            }
            return result;
        }
    }
}
