using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_291
{
    internal class _2260_Minimum_Consecutive_Cards_to_Pick_Up
    {

        public static int MinimumCardPickup(int[] cards)
        {

            Dictionary<int, List<int>> result = new Dictionary<int, List<int>>();

            for (int i = 0; i < cards.Length; i++)
            {
                if (result.ContainsKey(cards[i]))
                    result[cards[i]].Add(i);
                else
                    result[cards[i]] = new List<int>() { i };
            }
            var data = result.Where(x => x.Value.Count >= 2).ToList();
            var min = Int32.MaxValue;
            foreach (var item in data)
            {
                var minVal = GetMinVale(item.Value);
                min = Math.Min(minVal, min);
            }
            if (min == Int32.MaxValue)
                return -1;
            else
                return min;
        }
        public static int GetMinVale(List<int> value)
        {
            int len = value.Count;
            var crr = value.ToArray();
            var minVal = Int32.MaxValue;
            for (int i = 1; i < len; i++)
            {
                var diff = crr[i] - crr[i - 1] + 1;
                minVal = Math.Min(diff, minVal);
            }
            if (minVal == Int32.MaxValue)
                return -1;
            else
                return minVal;
        }

    }
}
