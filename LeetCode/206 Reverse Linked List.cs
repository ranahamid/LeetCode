using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ListNode_206
    {
        public int val;
        public ListNode_206 next;
        public ListNode_206(int val = 0, ListNode_206 next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    internal class Reverse_Linked_List
    {
        public ListNode_206 ReverseList_Recursive(ListNode_206 head)
        {
            if (head == null || head.next == null)
                return head;
            var node = ReverseList(head.next); //4,5

            head.next.next = head;
            head.next = null;
            return node;
        }

        //static void Main(string[] args)
        //{
        //    ListNode_206 five = new ListNode_206(5);
        //    ListNode_206 four = new ListNode_206(4, five);
        //    ListNode_206 three = new ListNode_206(3, four);
        //    ListNode_206 two = new ListNode_206(2, three);
        //    ListNode_206 one = new ListNode_206(1, two);
        //    Console.WriteLine(ReverseList(one));
        //}

        /// <summary>
        /// Runtime: 84 ms, faster than 97.04% of C# online submissions for Reverse Linked List.
        /// Memory Usage: 39 MB, less than 9.12% of C# online submissions for Reverse Linked List.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode_206 ReverseList(ListNode_206 head)
        {
            if (head == null)
                return null;
            ListNode_206 prevNode = null;
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
        public static ListNode_206 ReverseList2(ListNode_206 head)
        {

            ListNode_206 prevNode = null;
            while (head != null)
            {
                var nextNode = head.next;
                head.next = prevNode;

                prevNode = head;
                head = nextNode;
            }
            return prevNode;
        }
    }
}
