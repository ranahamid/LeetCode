using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _495
    {
        /// <summary>
        /// Runtime: 269 ms, faster than 5.13% of C# online submissions for Teemo Attacking.
        /// Memory Usage: 47.9 MB, less than 20.51% of C# online submissions for Teemo Attacking.
        /// </summary>
        /// <param name="timeSeries"></param>
        /// <param name="duration"></param>
        /// <returns></returns>
        public static int FindPoisonedDuration(int[] timeSeries, int duration)
        {
            //Array.Sort(timeSeries);
            var diff = 0;
            var result = 0;
            for (int i = 0; i < timeSeries.Length - 1; i++)
            {
                diff = timeSeries[i + 1] - timeSeries[i];
                if (diff >= duration)
                    result = result + duration;
                else
                    result = result + diff;
            }
            return result + duration;
        }

        /// <summary>
        /// TLE
        /// </summary>
        /// <param name="timeSeries"></param>
        /// <param name="duration"></param>
        /// <returns></returns>
        public static int FindPoisonedDuration_TLE(int[] timeSeries, int duration)
        {
            Array.Sort(timeSeries);
            var lastElement = timeSeries.LastOrDefault();
            var total = lastElement + duration + 1;
            var result = new int[total];
            for (int i = 0; i < timeSeries.Length; i++)
            {
                for (int j = timeSeries[i]; j < timeSeries[i] + duration; j++)
                {
                    result[j] = 1;
                }
            }
            var count = result.Where(x => x == 1).Count();
            return count;
        }
    }
}
