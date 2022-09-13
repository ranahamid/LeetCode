using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _914
    {
        public bool HasGroupsSizeX(int[] deck)
        {
            if (deck.Count() < 2)
                return false;
            var dic = new Dictionary<int, int>();
            foreach (var item in deck)
            {
                dic.TryAdd(item, 0);
                dic[item]++;
            }
            var values = dic.Select(x => x.Value).ToList();
            values.Sort();
            var num = values.FirstOrDefault();
            if (num == 1)
                return false;
            for (int i = 1; i < values.Count; i++)
            {
                num = gcd(num, values[i]);
            }
            return num >= 2;
        }
        public int gcd(int x, int y)
        {
            return x == 0 ? y : gcd(y % x, x);
        }
    }
}
