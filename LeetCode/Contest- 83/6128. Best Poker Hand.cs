using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest__83
{
    internal class _6128
    {
        public string BestHand(int[] ranks, char[] suits)
        {
            var count = 0;
            for (int i = 0; i < suits.Length - 1; i++)
            {
                if (suits[i] == suits[i + 1])
                {
                    count++;
                }
            }
            if (count == suits.Length - 1)
            {
                return "Flush";
            }
            var map = new Dictionary<int, int>();
            for (int i = 0; i < ranks.Length; i++)
            {
                if (map.ContainsKey(ranks[i]))
                {
                    map[ranks[i]]++;
                }
                else
                {
                    map[ranks[i]] = 1;
                }
            }

            var list = map.Select(x => x.Value).ToList();
            list.Sort();
            list.Reverse();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] >= 3)
                {
                    return "Three of a Kind";
                }
                else if (list[i] == 2)
                {
                    return "Pair";
                }
            }
            return "High Card";
        }
    }
}
