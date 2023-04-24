using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _1046
    {
        /// <summary>
        /// priority Queue
        /// </summary>
        /// <param name="stones"></param>
        /// <returns></returns>
        public int LastStoneWeight(int[] stones)
        {
            var pq = new PriorityQueue<int, int>();
            foreach (var item in stones)
            {
                pq.Enqueue(item, -item);
            }
            while (pq.Count > 1)
            {
                var item1 = pq.Dequeue();
                var item2 = pq.Dequeue();
                if (item1 > item2)
                {
                    var res = item1 - item2;
                    pq.Enqueue(res, -res);
                }
            }
            if (pq.Count == 0)
                return 0;
            return pq.Dequeue();
        }

        /// <summary>
        /// Runtime: 172 ms, faster than 8.27% of C# online submissions for Last Stone Weight.
        /// Memory Usage: 36.6 MB, less than 81.14% of C# online submissions for Last Stone Weight.
        /// </summary>
        /// <param name="stones"></param>
        /// <returns></returns>
        public static int LastStoneWeight_list(int[] stones)
        {
            var data = stones.ToList();
            while (data.Count > 1)
            {
                data.Sort();
                var y = data.LastOrDefault();
                var lastIndex = data.LastIndexOf(y);
                data.RemoveAt(lastIndex);

                var x = data.LastOrDefault();
                var seclastIndex = data.LastIndexOf(x);
                data.RemoveAt(seclastIndex);

                if (x == y)
                {
                    continue;
                }
                else if (x != y)
                {
                    var val = y - x;
                    data.Add(val);
                }

            }
            var res = data.FirstOrDefault();
            return res;
        }
    }
}
