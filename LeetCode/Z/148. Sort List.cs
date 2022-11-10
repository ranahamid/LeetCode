using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _148
    {
        /// <summary>
        /// Runtime: 167 ms, faster than 87.15% of C# online submissions for Sort List.
        /// Memory Usage: 51.3 MB, less than 19.14% of C# online submissions for Sort List.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode SortList(ListNode head)
        {
            var queue = new PriorityQueue<ListNode, int>();
            while (head != null)
            {
                queue.Enqueue(head, -head.val);
                head = head.next;
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
