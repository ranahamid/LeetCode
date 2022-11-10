using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    internal class _328
    {
        public ListNode OddEvenList(ListNode head)
        {
            if (head == null)
                return head;
            var odd = head;
            var even = head.next;
            var evenHead = head.next;
            while (even != null && even.next != null)
            {
                odd.next = even.next;
                odd = odd.next;
                even.next = odd.next;
                even = even.next;
            }
            odd.next = evenHead;
            return head;
        }
    }
}
