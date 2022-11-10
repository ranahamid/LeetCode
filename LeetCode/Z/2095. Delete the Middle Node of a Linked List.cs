using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class ListNode_2095
    {
        public int val;
        public ListNode_2095 next;
        public ListNode_2095(int val = 0, ListNode_2095 next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class _2095
    {
        /// <summary>
        /// Runtime: 544 ms, faster than 64.37% of C# online submissions for Delete the Middle Node of a Linked List.
        /// Memory Usage: 52.3 MB, less than 90.80% of C# online submissions for Delete the Middle Node of a Linked List.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public ListNode_2095 DeleteMiddle(ListNode_2095 head)
        {
            if (head.next == null)
                return null;
            var slow = head;
            var fast = head.next.next;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            slow.next = slow.next.next;
            return head;
        }
    }
}
