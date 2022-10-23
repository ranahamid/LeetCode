using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Contest_306
{
    internal class _2374
    {
        /// <summary>
        /// Runtime: 1641 ms, faster than 100.00% of C# online submissions for Node With Highest Edge Score.
       /// Memory Usage: 70.7 MB, less than 100.00% of C# online submissions for Node With Highest Edge Score.
        /// </summary>
        /// <param name="edges"></param>
        /// <returns></returns>
        public int EdgeScore(int[] edges)
        {
            var incVal = 0;
            long max = Int32.MinValue;
            var index = Int32.MinValue;
            SortedDictionary<int, HashSet<int>> edgePath = new SortedDictionary<int, HashSet<int>>();
            foreach (var item in edges)
            {
                edgePath.TryAdd(item, new HashSet<int>());
                edgePath[item].Add(incVal);
                incVal++;
            }
            foreach (var item in edgePath)
            {
                long total = 0;
                foreach (var val in item.Value)
                {
                    total += val;
                }
                if (total > max)
                {
                    max = total;
                    index = item.Key;
                }
            }
            return index;
        }
    }
}
