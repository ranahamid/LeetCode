using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _280
    {
        public void WiggleSort(int[] nums)
        {
            Array.Sort(nums);
            for (int i = 1; i < nums.Length - 1; i = i + 2)
                (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
        }
        //pq
        /// <summary>
        /// Runtime: 148 ms, faster than 80.77% of C# online submissions for Wiggle Sort.
        /// Memory Usage: 47.4 MB, less than 11.54% of C# online submissions for Wiggle Sort.
        /// </summary>
        /// <param name="nums"></param>
        public void WiggleSort_pq(int[] nums)
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
