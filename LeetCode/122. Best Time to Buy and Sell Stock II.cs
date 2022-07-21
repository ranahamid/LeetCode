using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _122
    {   /// <summary>
        /// Runtime: 110 ms, faster than 69.30% of C# online submissions for Best Time to Buy and Sell Stock II.
        /// Memory Usage: 37.7 MB, less than 97.14% of C# online submissions for Best Time to Buy and Sell Stock II.
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public static int MaxProfit(int[] prices)
        {
            var max = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                var diff = prices[i] - prices[i - 1];
                if (diff > 0)
                    max += prices[i] - prices[i - 1];
            }
            return max;
        }
        public static int MaxProfit_1(int[] prices)
        {
            var max = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                    max += prices[i] - prices[i - 1];
            }
            return max;
        }
    }
}
