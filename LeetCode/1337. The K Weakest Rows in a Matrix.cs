using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _1337
    {
        /// <summary>
        /// Runtime: 205 ms, faster than 66.97% of C# online submissions for The K Weakest Rows in a Matrix.
        /// Memory Usage: 45.3 MB, less than 23.96% of C# online submissions for The K Weakest Rows in a Matrix.
        /// </summary>
        /// <param name="mat"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public int[] KWeakestRows(int[][] mat, int k)
        {
            SortedDictionary<int, int> map = new SortedDictionary<int, int>();
            var counter = 0;
            foreach (var item in mat)
            {
                var ones = item.Count(x => x == 1);
                map.Add(counter++, ones);
            }
            var res = map.OrderBy(x => x.Value).Select(x => x.Key).Take(k).ToArray();
            return res;
        }
    }
}
