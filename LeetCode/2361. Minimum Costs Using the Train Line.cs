using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2361
    {
        /// <summary>
        /// Runtime: 389 ms, faster than 90.91% of C# online submissions for Minimum Costs Using the Train Line.
        /// Memory Usage: 61.6 MB, less than 27.27% of C# online submissions for Minimum Costs Using the Train Line.
        /// </summary>
        /// <param name="regular"></param>
        /// <param name="express"></param>
        /// <param name="expressCost"></param>
        /// <returns></returns>
        public long[] MinimumCosts(int[] regular, int[] express, int expressCost)
        {
            long r = 0;
            long e = expressCost;
            var result = new long[regular.Length];
            for (int i = 0; i < regular.Length; i++)
            {
                // save the original value to use for calculating min price for express 
                long tempR = r;
                // two choices for every regular stop: continue on regular track or use the express track (pay express cost) 
                r = Math.Min(tempR + regular[i], e + express[i]);
                // two choices: use the regular track + pay the express cost or continue on the express track 
                e = Math.Min(tempR + regular[i] + expressCost, e + express[i]);
                result[i] = Math.Min(r, e);
            }
            return result;
        }
    }
}
