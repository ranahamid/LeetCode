using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    #region PriorityQueue

    /// <summary>
    /// Runtime: 243 ms, faster than 48.89% of C# online submissions for Kth Largest Element in a Stream.
    /// Memory Usage: 49.2 MB, less than 89.34% of C# online submissions for Kth Largest Element in a Stream.
    /// </summary>
    public class KthLargest
    {
        PriorityQueue<int, int> queue;
        private int k;
        public KthLargest(int k, int[] nums)
        {
            this.k = k;
            queue = new PriorityQueue<int, int>();
            foreach (var item in nums)
            {
                Add(item);
            }
        }

        public int Add(int val)
        {
            queue.Enqueue(val, val);
            if (queue.Count > k)
                queue.Dequeue();
            return queue.Peek();
        }
    }


    #endregion
    #region Brute
    /// <summary>
    /// Runtime: 2879 ms, faster than 5.03% of C# online submissions for Kth Largest Element in a Stream.
    /// Memory Usage: 50.4 MB, less than 23.34% of C# online submissions for Kth Largest Element in a Stream.
    /// </summary>
    public class KthLargest_Brute
    {
        List<int> queue;
        private int k;
        public KthLargest_Brute(int k, int[] nums)
        {
            this.k = k;
            queue = new List<int>();
            foreach (var item in nums)
            {
                queue.Add(item);
            }
        }

        public int Add(int val)
        {
            queue.Add(val);
            queue.Sort();
            return queue[queue.Count - k];
        }
    }
    #endregion
}
