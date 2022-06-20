using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ListNode_2
    {
        public int val;
        public ListNode_2 next;
        public ListNode_2(int val = 0, ListNode_2 next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class _2_Add_Two_Numbers
    {
        public void Display()
        {
            ListNode_2 six = new ListNode_2(4);
            ListNode_2 five = new ListNode_2(6, six);
            ListNode_2 list2 = new ListNode_2(5, five);


            ListNode_2 three = new ListNode_2(3);
            ListNode_2 two = new ListNode_2(4, three);
            ListNode_2 list1 = new ListNode_2(2, two);
        }

        /// <summary>
        /// Runtime: 138 ms, faster than 44.62% of C# online submissions for Add Two Numbers.
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static ListNode_2 AddTwoNumbers(ListNode_2 l1, ListNode_2 l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;
            int carry = 0;
            var head = new ListNode_2(0);
            var tempNode = head;
            while (l1 != null || l2 != null || carry != 0)
            {
                if (l1 != null)
                {
                    carry += l1.val;
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    carry += l2.val;
                    l2 = l2.next;
                }
                var value = carry % 10;
                tempNode.next = new ListNode_2(value);
                carry = carry / 10;
                tempNode = tempNode.next;
            }
            return head.next;
        }
    }
}
