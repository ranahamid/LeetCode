using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class _83_Remove_Duplicates_from_Sorted_List
    {
        /// <summary>
        /// Runtime: 95 ms, faster than 85.89% of C# online submissions for Remove Duplicates from Sorted List.
        /// Memory Usage: 40.5 MB, less than 7.63% of C# online submissions for Remove Duplicates from Sorted List.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>

        public static ListNode DeleteDuplicates(ListNode head)
        {
            if (head == null)
                return null;
            var newNode = new ListNode(head.val);
            var resultHead = newNode;


            while (head != null)
            {
                if (head.val != newNode.val)
                {
                    var node = new ListNode(head.val);
                    newNode.next = node;
                    newNode = newNode.next;
                }
                head = head.next;
            }

            return resultHead;
        }
    }
}
