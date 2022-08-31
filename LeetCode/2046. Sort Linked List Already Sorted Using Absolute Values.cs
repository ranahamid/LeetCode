using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Solution;

namespace LeetCode
{
    internal class _2046
    {
        /// <summary>
        /// Runtime: 278 ms, faster than 61.54% of C# online submissions for Sort Linked List Already Sorted Using Absolute Values.
        /// Memory Usage: 56.5 MB, less than 30.77% of C# online submissions for Sort Linked List Already Sorted Using Absolute Values.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode SortLinkedList(ListNode head)
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
