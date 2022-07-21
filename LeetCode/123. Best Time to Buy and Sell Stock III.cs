using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _123
    {
        public static int MaxProfit(int[] prices)
        {
            var max = 0;
            var t2profit = 0;
            var minValue = Int32.MaxValue;
            var t2Cost = Int32.MaxValue;
            for (int i = 0; i < prices.Length; i++)
            {
                minValue = Math.Min(minValue, prices[i]);
                max = Math.Max(max, prices[i] - minValue);

                t2Cost = Math.Min(t2Cost, prices[i] - max);
                t2profit = Math.Max(t2profit, prices[i] - t2Cost);
            }
            return t2profit;
        }

    }
}
