using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _2073
    {
        /// <summary>
        /// Runtime: 91 ms, faster than 90.38% of C# online submissions for Time Needed to Buy Tickets.
        /// Memory Usage: 37.4 MB, less than 11.54% of C# online submissions for Time Needed to Buy Tickets.
        /// </summary>
        /// <param name="tickets"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static int TimeRequiredToBuy(int[] tickets, int k)
        {
            var result = 0;
            while (tickets[k] > 0)
            {
                for (int i = 0; i < tickets.Length; i++)
                {
                    if (tickets[i] > 0)
                    {
                        tickets[i]--;
                        result++;
                    }
                    if (tickets[k] == 0)
                        break;
                }
            }
            return result;
        }

    }
}
