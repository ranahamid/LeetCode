using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _234
    {
        #region recursion
        /// <summary>
        /// Runtime: 266 ms, faster than 87.59% of C# online submissions for Palindrome Linked List.
        /// Memory Usage: 61.4 MB, less than 5.88% of C# online submissions for Palindrome Linked List.
        /// </summary>
        public static ListNode firstPointer;
        public bool IsPalindrome(ListNode head)
        {
            firstPointer = head;
            return RecursivePalindrome(head);
        }
        public static bool RecursivePalindrome(ListNode currentNode)
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
        public bool IsPalindrome_Array(ListNode head)
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
