using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class ListNode_234
    {
        public int val;
        public ListNode_234 next;
        public ListNode_234(int val = 0, ListNode_234 next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class _234
    {
        #region recursion
        /// <summary>
        /// Runtime: 266 ms, faster than 87.59% of C# online submissions for Palindrome Linked List.
        /// Memory Usage: 61.4 MB, less than 5.88% of C# online submissions for Palindrome Linked List.
        /// </summary>
        public static ListNode_234 firstPointer;
        public bool IsPalindrome(ListNode_234 head)
        {
            firstPointer = head;
            return RecursivePalindrome(head);
        }
        public static bool RecursivePalindrome(ListNode_234 currentNode)
        {
            if (currentNode != null)
            {
                if (RecursivePalindrome(currentNode.next) == false)
                    return false;
                if (firstPointer.val != currentNode.val)
                {
                    return false;
                }
                firstPointer = firstPointer.next;
            }
            return true;
        }
        #endregion
        #region array
        public bool IsPalindrome_Array(ListNode_234 head)
        {
            var list = new List<int>();
            while (head != null)
            {
                list.Add(head.val);
                head = head.next;
            }
            var len = list.Count - 1;
            var first = 0;
            while (first < len)
            {
                if (list[first] != list[len])
                    return false;
                first++;
                len--;
            }
            return true;
        }
        #endregion
    }
}
