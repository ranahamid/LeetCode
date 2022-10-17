using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1124
    {
        public int LongestWPI(int[] hours)
        {
            int max = 0, current = 0;
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < hours.Length; i++)
            {
                var n = hours[i];
                if (n > 8)
                    current++;
                else
                    current--;

                if (current > 0)
                    max = i + 1;
                else
                {
                    dic.TryAdd(current, i);
                    if (dic.ContainsKey(current - 1))
                        max = Math.Max(max, i - dic[current - 1]);
                }
            }
            return max;
        }
    }
}
