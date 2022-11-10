using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    class _123
    {
        public int MaxProfit(int[] prices, int k = 2)
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

        public static int MaxProfit_1(int[] prices)
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
