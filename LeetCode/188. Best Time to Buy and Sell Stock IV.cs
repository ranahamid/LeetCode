using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _188
    {
        /// <summary>
        /// Runtime: 81 ms, faster than 98.58% of C# online submissions for Best Time to Buy and Sell Stock IV.
        /// Memory Usage: 38.9 MB, less than 39.01% of C# online submissions for Best Time to Buy and Sell Stock IV.
        /// </summary>
        /// <param name="k"></param>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit(int k, int[] prices)
        {
            var buy = new int[k + 1];
            var sell = new int[k + 1];
            for (int i = 0; i <= k; i++)
                buy[i] = Int32.MaxValue;
            foreach (var p in prices)
            {
                for (int i = 1; i <= k; i++)
                {
                    buy[i] = Math.Min(buy[i], p - sell[i - 1]);
                    sell[i] = Math.Max(sell[i], p - buy[i]);
                }
            }
            return sell[k];
        }
    }
}
