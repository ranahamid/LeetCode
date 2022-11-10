using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Z
{
    public class ListNode_83
    {
        public int val;
        public ListNode_83 next;

        public ListNode_83(int val = 0, ListNode_83 next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class _83_Remove_Duplicates_from_Sorted_List
    {
        /// <summary>
        /// Runtime: 95 ms, faster than 85.89% of C# online submissions for Remove Duplicates from Sorted List.
        /// Memory Usage: 40.5 MB, less than 7.63% of C# online submissions for Remove Duplicates from Sorted List.
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>

        public static ListNode_83 DeleteDuplicates(ListNode_83 head)
        {
            if (head == null)
                return null;
            var newNode = new ListNode_83(head.val);
            var resultHead = newNode;


            while (head != null)
            {
                if (head.val != newNode.val)
                {
                    var node = new ListNode_83(head.val);
                    newNode.next = node;
                    newNode = newNode.next;
                }
                head = head.next;
            }

            return resultHead;
        }
    }
}
