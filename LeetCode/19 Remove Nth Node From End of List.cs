using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ListNode_19
    {
        public int val;
        public ListNode_19 next;
        public ListNode_19(int val = 0, ListNode_19 next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class _19_Remove_Nth_Node_From_End_of_List
    { 
        public void Display()
        {
            ListNode_19 five = new ListNode_19(5);
            ListNode_19 four = new ListNode_19(4, five);
            ListNode_19 three = new ListNode_19(3, four);
            ListNode_19 two = new ListNode_19(2, three);
            ListNode_19 one = new ListNode_19(1, two);
        }
        public static ListNode_19 RemoveNthFromEnd(ListNode_19 head, int n)
        {
            var fast = head;
            var slow = head;
            while (n-- > 0)
            {
                fast = fast.next;
            }
            if (fast == null)
                return head.next;
            while (fast.next != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            slow.next = slow.next.next;
            return head;
        }
    }
}
