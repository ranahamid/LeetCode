using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    //public class ListNode
    //{
    //    public int val;
    //    public ListNode next;
    //    public ListNode(int x)
    //    {
    //        val = x;
    //        next = null;
    //    }
    //}
    internal class Linked_List_Cycle_II
    {
        public ListNode DetectCycle(ListNode head)
        {
            if (head == null || head.next == null)
                return null;
            var totoise = head;
            var hare = head;
            while (hare != null && hare.next != null)
            {
                totoise = totoise.next;
                hare = hare.next.next;

                if (hare == totoise)
                    break;
            }
            if (hare != totoise)
                return null;
            //check cycle
            var pointer = head;
            while (pointer != hare)
            {
                pointer = pointer.next;
                hare = hare.next;
            }
            return pointer;
        }
    }
}
