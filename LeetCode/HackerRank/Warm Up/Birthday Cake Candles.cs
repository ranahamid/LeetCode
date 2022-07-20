using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.HackerRank.Warm_Up
{
    internal class Birthday_Cake_Candles
    {
        public static int birthdayCakeCandles(List<int> candles)
        {
            candles.Sort();
            var item = candles.LastOrDefault();
            return candles.Count(x => x == item);
        }
    }
}
