using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _458
    {
        /// <summary>
        /// ///Runtime: 41 ms, faster than 10.00% of C# online submissions for Poor Pigs.
       /// Memory Usage: 25.5 MB, less than 70.00% of C# online submissions for Poor Pigs.
        /// </summary>
        /// <param name="buckets"></param>
        /// <param name="minutesToDie"></param>
        /// <param name="minutesToTest"></param>
        /// <returns></returns>
        public int PoorPigs(int buckets, int minutesToDie, int minutesToTest)
        {
            var states = minutesToTest / minutesToDie + 1;
            var pigs = Math.Ceiling(Math.Log(buckets) / Math.Log(states));
            return (int)pigs;
        }
        /// <summary>
        /// Runtime: 26 ms, faster than 100.00% of C# online submissions for Poor Pigs.
        ///        Memory Usage: 27 MB, less than 20.00% of C# online submissions for Poor Pigs.

        /// </summary>
        /// <param name="buckets"></param>
        /// <param name="minutesToDie"></param>
        /// <param name="minutesToTest"></param>
        /// <returns></returns>
        public int PoorPigs_1(int buckets, int minutesToDie, int minutesToTest)
        {

            int pigs = 0;
            while (Math.Pow((minutesToTest / minutesToDie + 1), pigs) < buckets)
                pigs++;
            return pigs;
        }
    }
}
