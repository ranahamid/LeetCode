using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
	class _121
	{
		/// <summary>
		/// Runtime: 406 ms, faster than 27.25% of C# online submissions for Best Time to Buy and Sell Stock.
		///Memory Usage: 47.1 MB, less than 44.71% of C# online submissions for Best Time to Buy and Sell Stock.

		/// </summary>
		/// <param name="prices"></param>
		/// <returns></returns>
		public static int MaxProfit(int[] prices)
		{
			var max = 0;
			var minValue = Int32.MaxValue;
			for (int i = 0; i < prices.Length; i++)
			{

				if (prices[i] < minValue)
					minValue = prices[i];

				if (prices[i] - minValue > max)
					max = prices[i] - minValue;
			}
			return max;
		}
		/// Runtime: 383 ms, faster than 38.94% of C# online submissions for Best Time to Buy and Sell Stock.
		/// Memory Usage: 47 MB, less than 60.82% of C# online submissions for Best Time to Buy and Sell Stock
		public int MaxProfit_1(int[] prices)
		{
			var max = 0;
			var minValue = Int32.MaxValue;
			for (int i = 0; i < prices.Length; i++)
			{
				minValue = Math.Min(minValue, prices[i]);
				max = Math.Max(max, prices[i] - minValue);
			}
			return max;
		}
		/// <summary>
		/// TLE
		/// </summary>
		/// <param name="prices"></param>
		/// <returns></returns>
		public static int MaxProfit_TLE(int[] prices)
		{
			var max = 0;
			for (int i = 0; i < prices.Length; i++)
			{
				for (int j = i + 1; j < prices.Length; j++)
				{
					max = Math.Max(max, prices[j] - prices[i]);
				}
			}
			return max;
		}


	}
}
