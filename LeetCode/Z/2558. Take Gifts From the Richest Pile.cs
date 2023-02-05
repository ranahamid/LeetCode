using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _2558
    {
        /// <summary>
        /// Runtime: 124 ms, faster than 100.00% of C# online submissions for Take Gifts From the Richest Pile.
        /// Memory Usage: 39.5 MB, less than 100.00% of C# online submissions for Take Gifts From the Richest Pile.
        /// </summary>
        /// <param name="gifts"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public long PickGifts(int[] gifts, int k)
        {
            var list = gifts.ToList();
            for (int i = 0; i < k; i++)
            {
                var max = list.Max();
                list.Remove(max);
                list.Add((int)Math.Sqrt(max));
            }
            long sum = 0;
            foreach (var n in list)
                sum += n;
            return sum;
        }
    }
}
