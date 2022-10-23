using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_310
{
    internal class _2404
    {
        /// <summary>
        /// Runtime: 215 ms, faster than 100.00% of C# online submissions for Most Frequent Even Element.
       /// Memory Usage: 51.1 MB, less than 100.00% of C# online submissions for Most Frequent Even Element.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MostFrequentEven(int[] nums)
        {
            SortedDictionary<int, int> map = new SortedDictionary<int, int>();
            foreach (var n in nums)
            {
                if (n % 2 == 0)
                {
                    map.TryAdd(n, 0);
                    map[n]++;
                }
            }
            if (map.Count > 0)
            {
                var max = map.Max(x => x.Value);
                foreach (var item in map)
                {
                    if (item.Value == max)
                        return item.Key;
                }
            }
            return -1;
        }
    }
}
