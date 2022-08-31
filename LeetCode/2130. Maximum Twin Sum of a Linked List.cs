using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ListNode_2130
    {
        public int val;
        public ListNode_2130 next;
        public ListNode_2130(int val = 0, ListNode_2130 next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class _2130
    {
        /// <summary>
        /// Runtime: 347 ms, faster than 76.83% of C# online submissions for Maximum Twin Sum of a Linked List.
        /// Memory Usage: 57.3 MB, less than 13.01% of C# online submissions for Maximum Twin Sum of a Linked List.
        /// </summary>
        public static ListNode_2130 firstPointer;
        public static int max = 0;
        public int PairSum(ListNode_2130 head)
        {
            firstPointer = head;
            max = 0;
            RecursivePalindrome(head);
            return max;
        }
        public static void RecursivePalindrome(ListNode_2130 currentNode)
        {
            if (currentNode != null)
            {
                RecursivePalindrome(currentNode.next);
                max = Math.Max(max, firstPointer.val + currentNode.val);
                firstPointer = firstPointer.next;
            }
        }
    }
}
