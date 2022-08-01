using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class ListNode_203
    {
        public int val;
        public ListNode_203 next;
        public ListNode_203(int val = 0, ListNode_203 next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
    internal class _203
    {
        /// <summary>
        /// Runtime: 109 ms, faster than 77.31% of C# online submissions for Remove Linked List Elements.
        /// Memory Usage: 40.2 MB, less than 78.91% of C# online submissions for Remove Linked List Elements.
        /// </summary>
        /// <param name="head"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public ListNode_203 RemoveElements(ListNode_203 head, int val)
        {
            var result = new ListNode_203();
            var temp = result;
            while (head != null)
            {
                if (head.val != val)
                {
                    result.next = new ListNode_203(head.val);
                    result = result.next;
                }
                head = head.next;
            }
            return temp.next;
        }
    }
}
