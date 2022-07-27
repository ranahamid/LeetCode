using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Premium
{
    internal class _1474
    {
        /// <summary>
        /// Runtime: 170 ms, faster than 17.86% of C# online submissions for Delete N Nodes After M Nodes of a Linked List.
        /// Memory Usage: 40.6 MB, less than 21.43% of C# online submissions for Delete N Nodes After M Nodes of a Linked List.
        /// </summary>
        /// <param name="head"></param>
        /// <param name="m"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public ListNode DeleteNodes(ListNode head, int m, int n)
        {
            var result = new ListNode();
            var ret = result;
            while (head != null)
            {
                for (int i = 0; i < m && head != null; i++)
                {
                    result.next = new ListNode(head.val);
                    result = result.next;

                    head = head.next;
                }
                for (int j = 0; j < n && head != null; j++)
                {
                    head = head.next;
                }
            }
            return ret.next;
        }
    }
}
