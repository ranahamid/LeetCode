using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _324
    {
        /// <summary>
        /// Runtime: 167 ms, faster than 60.00% of C# online submissions for Wiggle Sort II.
        /// Memory Usage: 51.8 MB, less than 5.00% of C# online submissions for Wiggle Sort II.
        /// </summary>
        /// <param name="nums"></param>
        public void WiggleSort(int[] nums)
        {
            var n = nums.Length;
            var pq = new PriorityQueue<int, int>();
            foreach (var item in nums)
                pq.Enqueue(item, -item);

            for (int i = 1; i < n; i = i + 2)
                nums[i] = pq.Dequeue();
            for (int i = 0; i < n; i = i + 2)
                nums[i] = pq.Dequeue();
        }
    }
}
