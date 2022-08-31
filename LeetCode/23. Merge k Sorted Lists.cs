using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _23
    {
        /// <summary>
        /// Runtime: 105 ms, faster than 94.97% of C# online submissions for Merge k Sorted Lists.
        /// Memory Usage: 40.5 MB, less than 36.68% of C# online submissions for Merge k Sorted Lists.
        /// </summary>
        /// <param name="lists"></param>
        /// <returns></returns>
        public ListNode MergeKLists(ListNode[] lists)
        {
            var queue = new PriorityQueue<ListNode, int>();
            foreach (var item in lists)
            {
                var head = item;
                while (head != null)
                {
                    queue.Enqueue(head, -head.val);
                    head = head.next;
                }
            }

            ListNode nextNode = null;
            while (queue.Count > 0)
            {
                var node = queue.Dequeue(); //1,2,3,4= dequeue [First 4], then 3, then 2 , then 1
                node.next = nextNode;//4, first null // second, node is 3, next is [4]// third, node is 2, next is [3,4]

                nextNode = node; // assign 4//second= [3,4]// third[2,3,4]
            }
            return nextNode;
        }
    }
}
