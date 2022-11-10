using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{

    internal class _1518
    {

        /// <summary>
        /// Runtime: 38 ms, faster than 20.83% of C# online submissions for Water Bottles.
        /// Memory Usage: 25.4 MB, less than 25.00% of C# online submissions for Water Bottles.
        /// </summary>
        /// <param name="numBottles"></param>
        /// <param name="numExchange"></param>
        /// <returns></returns>
        public static int NumWaterBottles(int numBottles, int numExchange)
        {
            var counter = numBottles;
            var tail = 0;
            while (numBottles >= numExchange)
            {
                var div = numBottles / numExchange;
                counter = counter + div;
                tail = numBottles % numExchange;
                numBottles = div + tail;
            }
            return counter;
        }

    }
}
