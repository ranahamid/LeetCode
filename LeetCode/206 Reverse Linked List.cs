using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    internal class Reverse_Linked_List
    {
        //static void Main(string[] args)
        //{
        //    ListNode five = new ListNode(5);
        //    ListNode four = new ListNode(4, five);
        //    ListNode three = new ListNode(3, four);
        //    ListNode two = new ListNode(2, three);
        //    ListNode one = new ListNode(1, two);
        //    Console.WriteLine(ReverseList(one));
        //}
        public static ListNode ReverseList(ListNode head)
        {
            if (head == null)
                return null;
            ListNode prevNode = null;
            var current = head;
            while (current != null)
            {
                var nextNode = current.next;
                current.next = prevNode;

                prevNode = current;
                current = nextNode;
            }
            return prevNode;
        }
    }
}
