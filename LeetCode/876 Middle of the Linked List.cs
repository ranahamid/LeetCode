using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{

    public class ListNode_876
    {
        public int val;
        public ListNode_876 next;

        public ListNode_876(int val = 0, ListNode_876 next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class _876_Middle_of_the_Linked_List
    {
        /// <summary>
        /// Runtime: 82 ms, faster than 96.43% of C# online submissions for Middle of the Linked List.
        /// Memory Usage: 38.1 MB, less than 6.57% of C# online submissions for Middle of the Linked List.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode_876 MiddleNode(ListNode_876 head)
        {
            var slow = head;
            var fast = head.next;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            if (fast != null)
            {
                return slow.next;
            }
            return slow;

        }
    }
}
